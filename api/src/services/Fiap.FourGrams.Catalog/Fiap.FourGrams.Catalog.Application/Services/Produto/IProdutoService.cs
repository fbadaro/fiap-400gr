using Fiap.FourGrams.Lib.Core.Services;

namespace Fiap.FourGrams.Catalog.Application;

public interface IProdutoService<TEntityDTO> : IApplicationService<TEntityDTO> 
    where TEntityDTO : class
{
}
