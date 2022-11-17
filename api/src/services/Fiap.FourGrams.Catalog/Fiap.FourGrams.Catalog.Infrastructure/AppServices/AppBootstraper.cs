using Fiap.FourGrams.Catalog.Application;
using Fiap.FourGrams.Catalog.Data;
using Fiap.FourGrams.Catalog.Domain;
using Fiap.FourGrams.Lib.Core.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Fiap.FourGrams.Catalog.Infrastructure.AppServices;

public static class AppBootstraper
{
    public static void AddDBContextApplication(this IServiceCollection services)
    {
        IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile(Directory.GetCurrentDirectory() + "/../Fiap.FourGrams.Catalog.API/appsettings.json")
                .Build();        

        services.AddDbContext<FourGramsContext>(options =>
                options.UseSqlServer(configuration["SqlServer:ConnectionString"]));
    }

    public static void AddServiceApplication(this IServiceCollection services)
    {
        // Categoria Services
        services.AddTransient<ICategoriaService<CategoriaDTO>, CategoriaService>();
        services.AddTransient<ICategoriaRepository, CategoriaRepository>();        
        services.AddTransient<IRepositoryBase<Categoria>, RepositorySQLBase<Categoria>>();

        // Produto Services
        services.AddTransient<IProdutoService<ProdutoDTO>, ProdutoService>();
        services.AddTransient<IProdutoRepository, ProdutoRepository>();        
        services.AddTransient<IRepositoryBase<Produto>, RepositorySQLBase<Produto>>();

        // DBContext
        services.AddScoped<DbContext>();
    }
}
