# Etapa 1: build
FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
WORKDIR /app

# Copia os arquivos
COPY *.sln ./
COPY SysObiOnline/*.csproj ./SysObiOnline/
RUN dotnet restore SysObiOnline/SysObiOnline.csproj

COPY SysObiOnline/. ./SysObiOnline/
WORKDIR /app/SysObiOnline
RUN dotnet publish -c Release -o /app/out

# Etapa 2: runtime
FROM mcr.microsoft.com/dotnet/aspnet:9.0
WORKDIR /app
COPY --from=build /app/out .

ENTRYPOINT ["dotnet", "SysObiOnline.dll"]
