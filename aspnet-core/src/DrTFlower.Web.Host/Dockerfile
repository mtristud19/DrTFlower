FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build

WORKDIR /src
COPY ["src/DrTFlower.Web.Host/DrTFlower.Web.Host.csproj", "src/DrTFlower.Web.Host/"]
COPY ["src/DrTFlower.Web.Core/DrTFlower.Web.Core.csproj", "src/DrTFlower.Web.Core/"]
COPY ["src/DrTFlower.Application/DrTFlower.Application.csproj", "src/DrTFlower.Application/"]
COPY ["src/DrTFlower.Core/DrTFlower.Core.csproj", "src/DrTFlower.Core/"]
COPY ["src/DrTFlower.EntityFrameworkCore/DrTFlower.EntityFrameworkCore.csproj", "src/DrTFlower.EntityFrameworkCore/"]
WORKDIR "/src/src/DrTFlower.Web.Host"
RUN dotnet restore 

WORKDIR /src
COPY ["src/DrTFlower.Web.Host", "src/DrTFlower.Web.Host"]
COPY ["src/DrTFlower.Web.Core", "src/DrTFlower.Web.Core"]
COPY ["src/DrTFlower.Application", "src/DrTFlower.Application"]
COPY ["src/DrTFlower.Core", "src/DrTFlower.Core"]
COPY ["src/DrTFlower.EntityFrameworkCore", "src/DrTFlower.EntityFrameworkCore"]
WORKDIR "/src/src/DrTFlower.Web.Host"
RUN dotnet publish -c Release -o /publish --no-restore

FROM mcr.microsoft.com/dotnet/aspnet:8.0
EXPOSE 80
WORKDIR /app
COPY --from=build /publish .
ENTRYPOINT ["dotnet", "DrTFlower.Web.Host.dll"]
