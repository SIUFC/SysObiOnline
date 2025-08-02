# Etapa 1: build
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /app

# Copia a solução e o projeto
COPY SysObiOnline.sln .
COPY SysObiOnline.csproj .

# Restaura dependências
RUN dotnet restore

# Copia o restante do código
COPY . .

# Publica o projeto
RUN dotnet publish -c Release -o /app/out

# Etapa 2: runtime
FROM mcr.microsoft.com/dotnet/aspnet:8.0.7
WORKDIR /app
COPY --from=build /app/out .

ENTRYPOINT ["dotnet", "SysObiOnline.dll"]
