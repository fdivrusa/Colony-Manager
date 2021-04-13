#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["src/ColonyManager.WebApi.Host/ColonyManager.WebApi.Host.csproj", "src/ColonyManager.WebApi.Host/"]
COPY ["src/ColonyManager.Application/ColonyManager.Application.csproj", "src/ColonyManager.Application/"]
COPY ["src/ColonyManager.Domain/ColonyManager.Domain.csproj", "src/ColonyManager.Domain/"]
COPY ["src/ColonyManager.Utility/ColonyManager.Utility.csproj", "src/ColonyManager.Utility/"]
COPY ["src/ColonyManager.Core/ColonyManager.Core.csproj", "src/ColonyManager.Core/"]
COPY ["src/ColonyManager.Data/ColonyManager.Data.csproj", "src/ColonyManager.Data/"]
RUN dotnet restore "src/ColonyManager.WebApi.Host/ColonyManager.WebApi.Host.csproj"
COPY . .
WORKDIR "/src/src/ColonyManager.WebApi.Host"
RUN dotnet build "ColonyManager.WebApi.Host.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ColonyManager.WebApi.Host.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ColonyManager.WebApi.Host.dll"]