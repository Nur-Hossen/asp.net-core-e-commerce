FROM mcr.microsoft.com/dotnet/core/aspnet:2.2-stretch-slim AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/core/sdk:2.2-stretch AS build
WORKDIR /src
COPY ["WebAppPages/WebAppPages.csproj", "WebAppPages/"]
RUN dotnet restore "WebAppPages/WebAppPages.csproj"
COPY . .
WORKDIR "/src/WebAppPages"
RUN dotnet build "WebAppPages.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "WebAppPages.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "WebAppPages.dll"]