using System.ComponentModel.DataAnnotations;

namespace Fiap.FourGrams.Catalog.Application;

public class ProdutoDTO
{
    public Guid Id { get; set; }

    [Required(ErrorMessage = "É necessário informar o nome para criação do produto", AllowEmptyStrings = false)]
    public string Nome { get; set; } = default!;

    [Required(ErrorMessage = "É necessário informar a descrição para criação do produto", AllowEmptyStrings = false)]
    public string Descricao { get; set; } = default!;

    [Required(ErrorMessage = "É necessário informar a descrição resumida para criação do produto", AllowEmptyStrings = false)]
    public string DescricaoResumida { get; set; } = default!;

    [Required(ErrorMessage = "É necessário informar a categoria para criação do produto", AllowEmptyStrings = false)]
    public CategoriaDTO Categoria { get; set; } = default!;

    public double? PrecoKilo { get; set; }

    public double? PrecoUnitario { get; set; }

    [Required(ErrorMessage = "É necessário informar o caminho da foto para criação do produto", AllowEmptyStrings = false)]
    public string CaminhoImagem { get; set; } = default!;
}
