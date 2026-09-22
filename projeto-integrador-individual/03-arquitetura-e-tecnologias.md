# 03 - Arquitetura e tecnologias

## Arquitetura proposta

O projeto está organizado em uma arquitetura de API REST em ASP.NET Core, com separação em camadas:

- Controllers: expõem os endpoints da API.
- Services: encapsulam regras de negócios.
- Repositories: acessam dados e encapsulam lógica de persistência.
- Models: representam entidades do domínio.
- Data: contexto do Entity Framework Core.
- Helpers: auxiliares de autenticação e segurança.

## Estrutura observada no repositório

- `Controllers/` — endpoints de autenticação, usuários, questões e quizzes.
- `Service/` — lógica de negócio para usuários, questões e respostas.
- `Repository/` — operações de persistência.
- `Models/` — entidades como `Users`, `Question`, `QuizResult`, `Report`, `AnswerGiven`.
- `Data/AppDbContext.cs` — contexto principal do banco.
- `Program.cs` — configuração de serviços, JWT, Swagger e CORS.

## Tecnologias

- ASP.NET Core — aplicação backend.
- C# — linguagem principal.
- Entity Framework Core — ORM para acesso ao SQL Server.
- SQL Server — banco de dados relacional.
- JWT — autenticação segura.
- Swagger / OpenAPI — documentação da API.
- BCrypt — hash de senhas.

## Fluxo principal

1. usuário acessa endpoint de autenticação;
2. validação de credenciais e geração do JWT;
3. uso do token em rotas protegidas;
4. acesso às questões e ao quiz mediante autenticação/autorização;
5. persistência no banco e retorno de status e relatórios.

## Vantagens da arquitetura

- separação clara de responsabilidades;
- facilita manutenção e evolução;
- reduz acoplamento entre regra de negócio e acesso a dados;
- melhora reutilização e testabilidade.

## Considerações de integração

A API foi construída para operar em conjunto com aplicação frontend e pode ser usada em ambientes locais ou em containerização com Docker.
