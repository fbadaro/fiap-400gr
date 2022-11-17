using AutoMapper;
using Fiap.FourGrams.Catalog.Application;
using Microsoft.Extensions.DependencyInjection;

namespace Fiap.FourGrams.Catalog.Infrastructure.AppConfigurations;

public static class AutoMapperConfiguration
{
    public static void AddAutoMapperApplication(this IServiceCollection services, params System.Reflection.Assembly[] assemblies)
    {
        services.AddAutoMapper(assemblies);
        services.AddSingleton<IConfigurationProvider>(AutoMapperConfig.RegisterMappings());
    }
}