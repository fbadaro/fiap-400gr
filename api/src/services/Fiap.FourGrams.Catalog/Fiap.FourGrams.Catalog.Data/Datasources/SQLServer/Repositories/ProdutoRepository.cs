using Fiap.FourGrams.Catalog.Domain;

namespace Fiap.FourGrams.Catalog.Data;

public class ProdutoRepository : RepositorySQLBase<Produto>, IProdutoRepository
{
    public ProdutoRepository(FourGramsContext context) : base(context)
    {
    }
}