using Fiap.FourGrams.Lib.Core.Services;

namespace Fiap.FourGrams.Catalog.Application;

public interface ICategoriaService<TEntityDTO> : IApplicationService<TEntityDTO>
    where TEntityDTO : class
{
}
