namespace Fiap.FourGrams.Lib.Core.Repositories;

public interface IRepositoryBase<TEntity, TPrimaryKey> : IDisposable
    where TEntity : IEntityBase<TPrimaryKey>
{
    Task<IEnumerable<TEntity>> GetAllAsync();

    Task<TEntity> GetById(TPrimaryKey id);

    Task<TEntity> CreateAsync(TEntity entity);

    Task<TEntity> UpdateAsync(TEntity entity);

    Task DeleteAsync(TPrimaryKey id);
}

public interface IRepositoryBase<TEntity> : IRepositoryBase<TEntity, Guid> 
    where TEntity : IEntityBase<Guid>
{
}