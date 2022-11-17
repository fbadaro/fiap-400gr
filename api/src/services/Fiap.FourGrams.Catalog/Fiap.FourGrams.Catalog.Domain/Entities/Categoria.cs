namespace Fiap.FourGrams.Catalog.Domain;

public class Categoria : EntityBase
{
    #region Constructor

    public Categoria(string nome) => Nome = nome;

    private Categoria() { }

    #endregion

    #region Properties

    public string Nome { get; init; } = default!;

    public string? Descricao { get; private set; }

    public double? Desconto { get; private set; }

    #endregion
}
