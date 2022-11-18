using Fiap.FourGrams.Catalog.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Fiap.FourGrams.Catalog.Data;

public class CategoriaMapping : IEntityTypeConfiguration<Categoria>
{
    public void Configure(EntityTypeBuilder<Categoria> builder)
    {
        builder.ToTable("GR01_CATEGOR");

        builder.HasKey(x => x.Id);

        builder.Property(x => x.Nome)
            .IsRequired()
            .HasMaxLength(50);

        builder.Property(x => x.Descricao)
            .HasMaxLength(250);

        builder.Property(x => x.Desconto);
    }
}
