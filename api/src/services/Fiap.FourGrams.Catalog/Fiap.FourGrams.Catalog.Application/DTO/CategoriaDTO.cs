using System.ComponentModel.DataAnnotations;

namespace Fiap.FourGrams.Catalog.Application;

public class CategoriaDTO
{
    public Guid Id { get; set; }

    [Required(ErrorMessage = "É necessário informar o nome para criação da categoria", AllowEmptyStrings = false)]
    public string Nome { get; set; } = default!;

    public string? Descricao { get; set; }

    public double? Desconto { get; set; }
}
