# 02 - Requisitos funcionais e não funcionais

## Requisitos funcionais

1. Cadastro de usuários
   - o sistema deve permitir o cadastro de usuários com nome, e-mail, senha e papel.

2. Autenticação
   - o sistema deve autenticar usuários com e-mail e senha;
   - deve gerar token JWT para acesso às rotas protegidas.

3. Gestão de questões
   - o sistema deve permitir criação, consulta e atualização de questões;
   - cada questão deve possuir atributos como nome, nível, conteúdo, ano, fase e alternativas.

4. Filtros de busca
   - o sistema deve permitir buscar questões por nível, ano e fase.

5. Resolução de quiz
   - o usuário deve enviar uma resposta para uma questão;
   - o sistema deve verificar se a resposta está correta;
   - deve registrar o resultado do usuário.

6. Relatórios
   - o sistema deve gerar relatório de acertos, erros e quantidade de questões respondidas;
   - deve distinguir por nível da questão.

7. Autorização
   - rotas de administração devem exigir perfil de administrador;
   - acesso público pode ser configurado para rotas de consulta ou filtro.

## Requisitos não funcionais

1. Segurança
   - uso de senha codificada com BCrypt;
   - autenticação baseada em JWT;
   - validação de tokens no backend.

2. Desempenho
   - consultas devem ser rápidas em bases de dados com volume moderado;
   - uso de EF Core e consultas específicas reduz overhead.

3. Manutenibilidade
   - arquitetura organizada em controllers, services e repositories;
   - separação de responsabilidades facilita evolução.

4. Compatibilidade
   - aplicação em ambiente ASP.NET Core;
   - suporte a integração com frontend em React/JavaScript ou aplicativos Web.

5. Observabilidade
   - uso de Swagger para documentação da API;
   - estrutura de retorno padronizada em mensagens de erro e sucesso.

6. Escalabilidade
   - separação em módulos permite crescimento do sistema com mais entidades e regras de negócios.

## Prioridade de implementação

- Alta: autenticação, gestão de usuários, questionário e relatórios.
- Média: filtros por nível/ano/fase e melhorias de interface/API.
- Média/baixa: otimizações de performance e expansões de regras administrativas.

## Critérios de aceitação

- usuário consegue se cadastrar;
- autenticação gera token válido;
- administrador consegue criar e atualizar questões;
- aluno consegue responder questão e obter feedback;
- relatório exibe estatísticas corretas;
- API responde de forma consistente com mensagens claras.
