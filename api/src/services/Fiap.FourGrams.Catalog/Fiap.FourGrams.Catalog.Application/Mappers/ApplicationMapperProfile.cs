using AutoMapper;
using Fiap.FourGrams.Catalog.Domain;

namespace Fiap.FourGrams.Catalog.Application;

public class AutoMapperConfig
{
    protected AutoMapperConfig() { }

    public static MapperConfiguration RegisterMappings() =>
        new(config =>
       {
           config.AllowNullCollections = true;
           config.AddProfile(new ApplicationMapperProfile());
       });
}

public class ApplicationMapperProfile : Profile
{
    public ApplicationMapperProfile()
    {
        CreateMap<ProdutoDTO, Produto>().ReverseMap();
        CreateMap<CategoriaDTO, Categoria>().ReverseMap();
    }
}