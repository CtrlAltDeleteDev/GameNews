#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["src/GameNews.WebApi/GameNews.WebApi.csproj", "src/GameNews.WebApi/"]
COPY ["src/GameNews.Infrastructure/GameNews.Infrastructure.csproj", "src/GameNews.Infrastructure/"]
RUN dotnet restore "src/GameNews.WebApi/GameNews.WebApi.csproj"
COPY . .
WORKDIR "/src/src/GameNews.WebApi"
RUN dotnet build "GameNews.WebApi.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "GameNews.WebApi.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "GameNews.WebApi.dll"]
