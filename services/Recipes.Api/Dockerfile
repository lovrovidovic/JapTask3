#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["Recipes.Api/Recipes.Api.csproj", "Recipes.Api/"]
COPY ["Recipes.Core/Recipes.Core.csproj", "Recipes.Core/"]
COPY ["Recipes.Common/Recipes.Common.csproj", "Recipes.Common/"]
COPY ["Recipes.Services/Recipes.Services.csproj", "Recipes.Services/"]
COPY ["Recipes.Database/Recipes.Database.csproj", "Recipes.Database/"]
COPY ["Recipes.Mapper/Recipes.Mapper.csproj", "Recipes.Mapper/"]
RUN dotnet restore "Recipes.Api/Recipes.Api.csproj"
COPY . .
WORKDIR "/src/Recipes.Api"
RUN dotnet build "Recipes.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Recipes.Api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Recipes.Api.dll"]
