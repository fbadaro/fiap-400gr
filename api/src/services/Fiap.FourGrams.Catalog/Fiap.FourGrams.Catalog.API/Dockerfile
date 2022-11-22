#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["src/services/Fiap.FourGrams.Catalog/Fiap.FourGrams.Catalog.API/Fiap.FourGrams.Catalog.API.csproj", "src/services/Fiap.FourGrams.Catalog/Fiap.FourGrams.Catalog.API/"]
COPY ["src/services/Fiap.FourGrams.Catalog/Fiap.FourGrams.Catalog.Application/Fiap.FourGrams.Catalog.Application.csproj", "src/services/Fiap.FourGrams.Catalog/Fiap.FourGrams.Catalog.Application/"]
COPY ["src/services/Fiap.FourGrams.Catalog/Fiap.FourGrams.Catalog.Data/Fiap.FourGrams.Catalog.Data.csproj", "src/services/Fiap.FourGrams.Catalog/Fiap.FourGrams.Catalog.Data/"]
COPY ["src/services/Fiap.FourGrams.Catalog/Fiap.FourGrams.Catalog.Domain/Fiap.FourGrams.Catalog.Domain.csproj", "src/services/Fiap.FourGrams.Catalog/Fiap.FourGrams.Catalog.Domain/"]
COPY ["src/services/Fiap.FourGrams.Catalog/Fiap.FourGrams.Catalog.Infrastructure/Fiap.FourGrams.Catalog.Infrastructure.csproj", "src/services/Fiap.FourGrams.Catalog/Fiap.FourGrams.Catalog.Infrastructure/"]
RUN dotnet restore "src/services/Fiap.FourGrams.Catalog/Fiap.FourGrams.Catalog.API/Fiap.FourGrams.Catalog.API.csproj"
COPY . .
WORKDIR "/src/src/services/Fiap.FourGrams.Catalog/Fiap.FourGrams.Catalog.API"
RUN dotnet build "Fiap.FourGrams.Catalog.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Fiap.FourGrams.Catalog.API.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Fiap.FourGrams.Catalog.API.dll"]