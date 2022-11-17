using Fiap.FourGrams.Lib.Core.Entities;
using Fiap.FourGrams.Lib.Core.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Fiap.FourGrams.Catalog.Data;

public class RepositorySQLBase<TEntity, TPrimaryKey> : IRepositoryBase<TEntity, TPrimaryKey>
    where TEntity : class, IEntityBase<TPrimaryKey>
{
    protected readonly FourGramsContext _context;

    public RepositorySQLBase(FourGramsContext context) => _context = context;

    public async Task<TEntity> CreateAsync(TEntity entity)
    {
        _context.Add(entity);
        await _context.SaveChangesAsync();
        return entity;
    }

    public async Task DeleteAsync(TPrimaryKey id)
    {
        _context.Remove(await GetByIdAsync(id));
        await _context.SaveChangesAsync();
    }

    public async Task<IEnumerable<TEntity>> GetAllAsync()
    {
        return await _context.Set<TEntity>().AsNoTracking().ToListAsync();
    }

    public async Task<TEntity> GetByIdAsync(TPrimaryKey id)
    {
        var entity = await _context.Set<TEntity>().FindAsync(id);
        return entity == null ? throw new Exception("Entidade não encontrada na base de dados") : entity!;
    }

    public async Task<TEntity> UpdateAsync(TEntity entity)
    {
        _context.Update(entity);
        await _context.SaveChangesAsync();
        return entity;
    }

    public void Dispose() => _context.Dispose();
}

public class RepositorySQLBase<TEntity> : RepositorySQLBase<TEntity, Guid>, IRepositoryBase<TEntity>
     where TEntity : class, IEntityBase<Guid>
{
    public RepositorySQLBase(FourGramsContext context) : base(context)
    {
    }
}