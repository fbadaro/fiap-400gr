namespace Fiap.FourGrams.Lib.Core.Services;

public interface IApplicationService<TEntityDTO, TPrimaryKey> : IDisposable
    where TEntityDTO : class
{
    Task<List<TEntityDTO>> GetAllAsync();

    Task<TEntityDTO> GetByIdAsync(TPrimaryKey id);

    Task<TEntityDTO> CreateAsync(TEntityDTO entityModel);

    Task<TEntityDTO> UpdateAsync(TEntityDTO entityModel);

    Task DeleteAsync(TPrimaryKey id);
}

public interface IApplicationService<TEntityDTO> : IApplicationService<TEntityDTO, Guid> 
    where TEntityDTO : class
{
}