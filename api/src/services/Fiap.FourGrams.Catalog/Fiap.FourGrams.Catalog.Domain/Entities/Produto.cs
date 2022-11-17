namespace Fiap.FourGrams.Catalog.Domain;

public class Produto : EntityBase
{
    #region Constructor

    public Produto(
        string nome,
        string descricao,
        string descricaoResumida,
        bool destaque,
        Categoria categoria,
        double? precoKilo,
        double? precoUnitario,
        string caminhoImagem
    )
        => (Nome, Descricao, DescricaoResumida, Destaque, Categoria, PrecoKilo, PrecoUnitario, CaminhoImagem)
        = (nome, descricao, descricaoResumida, destaque, categoria, precoKilo, precoUnitario, caminhoImagem);

    private Produto() { }

    #endregion

    #region Properties

    public string Nome { get; init; } = default!;

    public string Descricao { get; init; } = default!;

    public string DescricaoResumida { get; init; } = default!;

    public bool Destaque { get; init; } = false;

    public Categoria Categoria { get; init; } = default!;

    public double? PrecoKilo { get; private set; }

    public double? PrecoUnitario { get; private set; }

    public double? DescontoExclusivo { get; private set; }

    public string CaminhoImagem { get; init; } = default!;

    #endregion
}
