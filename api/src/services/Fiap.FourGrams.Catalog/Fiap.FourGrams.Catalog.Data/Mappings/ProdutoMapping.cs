using Fiap.FourGrams.Catalog.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Fiap.FourGrams.Catalog.Data;

public class ProdutoMapping : IEntityTypeConfiguration<Produto>
{
    public void Configure(EntityTypeBuilder<Produto> builder)
    {
        builder.ToTable("GR02_PRODUTO");

        builder.HasKey(x => x.Id);

        builder.Property(x => x.Nome)
            .IsRequired()
            .HasMaxLength(250);

        builder.Property(x => x.Descricao)
            .IsRequired();

        builder.Property(x => x.DescricaoResumida)
            .IsRequired()
            .HasMaxLength(50);

        builder.Property(x => x.PrecoKilo);

        builder.Property(x => x.PrecoUnitario);

        builder.Property(x => x.DescontoExclusivo);

        builder.Property(x => x.CaminhoImagem)
            .IsRequired();
    }
}