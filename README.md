# 🧠 SysObiOnline - OBI Back-End

[![Build Status](https://img.shields.io/badge/build-passing-brightgreen)](https://github.com/PedroAlvesPro/SysObiOnline/actions)
[![License](https://img.shields.io/badge/license-UFC-blue)](#licença)
[![.NET](https://img.shields.io/badge/.NET-8.0-blueviolet)](https://dotnet.microsoft.com/)
[![SQL Server](https://img.shields.io/badge/SQL%20Server-used-red)](https://www.microsoft.com/en-us/sql-server)

Sistema de questões para alunos da **Olimpíada Brasileira de Informática (OBI)**, desenvolvido pela **Universidade Federal do Ceará (UFC)**.

Criado por [@PedroAlvesPro](https://github.com/PedroAlvesPro), o projeto tem como objetivo **simplificar o acesso dos alunos às questões da OBI**.

---

## 📷 Preview

> *Tela de login do sistema (exemplo):*

![screenshot](https://github.com/PedroAlvesPro/SysObiOnline/raw/main/docs/screenshot-login.png)

> *(Substitua pelo caminho da sua imagem real.)*

---

## 📦 Tecnologias Utilizadas

- ASP.NET Core
- Entity Framework Core
- SQL Server
- C#

---

## ✅ Requisitos para Executar o Projeto

### 🔧 A) Instalar as Dependências

Certifique-se de que os seguintes componentes estão instalados:

- [.NET SDK](https://dotnet.microsoft.com/en-us/download)
- **ASP.NET Core**
- **Entity Framework Core**
- **SQL Server** (local ou remoto)
- **SQL Server Management Studio (SSMS)**

No Visual Studio, adicione os pacotes via **NuGet** conforme necessário.

---

### 🗃️ B) Configurar o Banco de Dados

#### 1. Criar o Banco Local

Abra o SSMS (SQL Server Management Studio) e execute:

Certifique-se de iniciar o serviço do banco

CREATE DATABASE SysObi;
```sql
🔹 Autenticação do Windows (padrão):
json
Copiar
Editar
"ConnectionStrings": {
  "DefaultConnection": "Server=localhost\\SQLEXPRESS;Database=SysObi;Integrated Security=True;TrustServerCertificate=True;"
}
🔹 Autenticação por login e senha:
json
Copiar
Editar
"ConnectionStrings": {
  "DefaultConnection": "Server=localhost\\SQLEXPRESS;Database=SysObi;User Id=SEU_USUARIO;Password=SUA_SENHA;TrustServerCertificate=True;"
}
```
🚀 Executando o Projeto
Siga os passos abaixo para executar o projeto localmente:

bash
Copiar
Editar
# Restaure os pacotes do projeto
dotnet restore

# (Opcional) Aplique as migrações do banco de dados
dotnet ef database update

# Execute o projeto
dotnet run
