# 06 - API e mapa de endpoints

## Endpoints principais

### Autenticação

- `POST /api/Login/login` - autenticar usuário e gerar token JWT.
- `POST /api/Login/register` - cadastro de usuário, conforme a API de autenticação.

### Usuários

- `GET /api/User/{id}` - busca usuário por ID.
- `POST /api/User/create` - criação de usuário.
- `PUT /api/User/update/{id}` - atualização de dados do usuário.
- `DELETE /api/User/delete/{id}` - exclusão.

### Questões

- `POST /api/Question/create` - criação de questão.
- `GET /api/Question/{name}` - busca questão por nome.
- `PUT /api/Question/update/{name}` - atualização da questão.
- `GET /api/Question/all-names` - listagem dos nomes das questões.
- `GET /api/Question/filter?level={level}&year={year}&phase={phase}` - filtro de questões.

### Quiz

- `POST /api/Quiz/submit` - envio de resposta e avaliação do quiz.
- `GET /api/Quiz/report/{userId}` - geração do relatório de desempenho.

## Observações de segurança

- rotas administrativas da API utilizam autorização por perfil `Admin`.
- rotas de consulta podem estar disponíveis com autorização mais ampla ou anônima, conforme necessidade.
- todos os endpoints devem ser consumidos com token JWT válido.

## Documentação da API

A aplicação disponibiliza documentação Swagger, o que facilita a análise dos endpoints e da estrutura das requisições.

## Conclusão

O backend do SysObiOnline oferece uma API funcional para gestão de conteúdo e avaliação de desempenho, com endpoints bem definidos e alinhados ao objetivo educativo e administrativo do sistema.
