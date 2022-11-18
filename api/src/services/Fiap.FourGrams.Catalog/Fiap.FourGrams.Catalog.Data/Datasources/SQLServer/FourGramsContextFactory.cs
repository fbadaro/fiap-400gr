using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Fiap.FourGrams.Catalog.Data;

public class FourGramsContextFactory : IDesignTimeDbContextFactory<FourGramsContext>
{
    public FourGramsContext CreateDbContext(string[] args)
    {
        try
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile(Directory.GetCurrentDirectory() + "/../Fiap.FourGrams.Catalog.API/appsettings.json")
                .Build();

            var builder = new DbContextOptionsBuilder<FourGramsContext>();

            builder.UseSqlServer(configuration["SqlServer:ConnectionString"], opt =>
                opt.MigrationsHistoryTable("MigrationFourHunGramsContext"));

            return new FourGramsContext(builder.Options);
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }
}