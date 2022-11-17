using Fiap.FourGrams.Catalog.Domain;

namespace Fiap.FourGrams.Catalog.Data;

public class CategoriaRepository : RepositorySQLBase<Categoria>, ICategoriaRepository
{
    public CategoriaRepository(FourGramsContext context) : base(context)
    {
    }
}
