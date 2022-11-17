using Fiap.FourGrams.Catalog.Application;

namespace Fiap.FourGrams.Catalog.API.Actions;

public static class CatalogoEndpoint
{
    public static void MapCatalogoEndpoint(this WebApplication app)
    {
        // LIST
        app!.MapGet("/catalogo", async (IProdutoService<ProdutoDTO> _catalogoAppService) =>
            await _catalogoAppService.GetAllAsync())
        .Produces<List<ProdutoDTO>>(StatusCodes.Status200OK)
        .WithName("GetCatalogo")
        .WithTags("Catalogo");

        // GET
        app!.MapGet("/catalogo/{id}", async (IProdutoService<ProdutoDTO> _catalogoAppService, Guid id) =>
        {
            var result = await _catalogoAppService.GetByIdAsync(id);

            return result != null
                ? Results.Ok(result)
                : Results.NotFound();
        })
        .Produces<ProdutoDTO>(StatusCodes.Status200OK)
        .Produces(StatusCodes.Status404NotFound)
        .WithName("GetCatalogoById")
        .WithTags("Catalogo");

        // POST
        app!.MapPost("/catalogo", async (IProdutoService<ProdutoDTO> _catalogoAppService, ProdutoDTO Catalogo) =>
        {
            var result = await _catalogoAppService.CreateAsync(Catalogo);

            return result != null
            ? Results.CreatedAtRoute("GetCatalogoById", new { id = result.Id }, Catalogo)
            : Results.BadRequest("Houve um problema ao salvar o registro");
        })
        .Produces<ProdutoDTO>(StatusCodes.Status201Created)
        .Produces(StatusCodes.Status400BadRequest)
        .WithName("PostCatalogo")
        .WithTags("Catalogo");

        // UPDATE
        app!.MapPut("/catalogo/{id}", async (IProdutoService<ProdutoDTO> _catalogoAppService, Guid id, ProdutoDTO Catalogo) =>
        {
            var result = await _catalogoAppService.UpdateAsync(Catalogo);

            return result != null
                ? Results.NoContent()
                : Results.BadRequest("Houve um problema ao salvar o registro");

        })
        .Produces(StatusCodes.Status204NoContent)
        .Produces(StatusCodes.Status400BadRequest)
        .WithName("PutCatalogo")
        .WithTags("Catalogo");

        // DELETE
        app!.MapDelete("/catalogo/{id}", async (IProdutoService<ProdutoDTO> _catalogoAppService, Guid id) =>
            await _catalogoAppService.DeleteAsync(id))
        .Produces(StatusCodes.Status400BadRequest)
        .Produces(StatusCodes.Status204NoContent)
        .Produces(StatusCodes.Status404NotFound)
        .WithName("DeleteCatalogo")
        .WithTags("Catalogo");
    }
}
