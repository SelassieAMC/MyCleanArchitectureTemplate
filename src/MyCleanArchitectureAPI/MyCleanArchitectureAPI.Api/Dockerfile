#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["src/MyCleanArchitectureAPI/MyCleanArchitectureAPI.Api/MyCleanArchitectureAPI.Api.csproj", "src/MyCleanArchitectureAPI/MyCleanArchitectureAPI.Api/"]
COPY ["src/MyCleanArchitectureAPI/MyCleanArchitectureAPI.Application/MyCleanArchitectureAPI.Application.csproj", "src/MyCleanArchitectureAPI/MyCleanArchitectureAPI.Application/"]
COPY ["src/MyCleanArchitectureAPI/MyCleanArchitectureAPI.Core/MyCleanArchitectureAPI.Core.csproj", "src/MyCleanArchitectureAPI/MyCleanArchitectureAPI.Core/"]
COPY ["src/MyCleanArchitectureAPI/MyCleanArchitectureAPI.Infraestructure/MyCleanArchitectureAPI.Infraestructure.csproj", "src/MyCleanArchitectureAPI/MyCleanArchitectureAPI.Infraestructure/"]
RUN dotnet restore "src/MyCleanArchitectureAPI/MyCleanArchitectureAPI.Api/MyCleanArchitectureAPI.Api.csproj"
COPY . .
WORKDIR "/src/src/MyCleanArchitectureAPI/MyCleanArchitectureAPI.Api"
RUN dotnet build "MyCleanArchitectureAPI.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "MyCleanArchitectureAPI.Api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "MyCleanArchitectureAPI.Api.dll"]