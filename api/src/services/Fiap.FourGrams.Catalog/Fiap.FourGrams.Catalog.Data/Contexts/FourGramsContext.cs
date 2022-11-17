using Fiap.FourGrams.Catalog.Domain;
using Microsoft.EntityFrameworkCore;

namespace Fiap.FourGrams.Catalog.Data;

public class FourGramsContext : DbContext
{
    public FourGramsContext(DbContextOptions<FourGramsContext> options) : base(options) { }

    public DbSet<Categoria> Categoria { get; set; } = null!;

    public DbSet<Produto> Produto { get; set; } = null!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(FourGramsContext).Assembly);
    }
}