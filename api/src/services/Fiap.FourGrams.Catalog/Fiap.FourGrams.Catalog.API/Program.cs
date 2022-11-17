using Fiap.FourGrams.Catalog.API.Actions;
using Fiap.FourGrams.Catalog.Infrastructure.AppConfigurations;
using Fiap.FourGrams.Catalog.Infrastructure.AppServices;
using Microsoft.AspNetCore.Http.Json;
using Microsoft.OpenApi.Models;
using System.Text.Json;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

builder.Services.Configure<JsonOptions>(options =>
{
    options.SerializerOptions.PropertyNamingPolicy = JsonNamingPolicy.CamelCase;
    options.SerializerOptions.Converters.Add(new JsonStringEnumConverter(JsonNamingPolicy.CamelCase));
});

builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen(options => {
    options.SwaggerDoc("v1", new OpenApiInfo
    {
        Version = "v1",
        Title = "400Gramas API",
        Description = "Api do aplicativo 400gramas",
        Contact = new OpenApiContact
        {
            Name = "400gramas.com.br",
            Url = new Uri("https://www.400gramas.com.br/")
        },
    });
});

builder.Services.AddCors(options => options.AddPolicy("400GramasCorsPolicy", builder =>
{
    builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader();
}));

builder.Services.AddAutoMapperApplication(typeof(Program).Assembly);
builder.Services.AddDBContextApplication();
builder.Services.AddServiceApplication();

var app = builder.Build();
app.UseSwagger();
app.UseSwaggerUI();
app.UseCors("400GramasCorsPolicy");
app.UseHttpsRedirection();

// Endpoints
app.MapCatalogoEndpoint();

app.Run();