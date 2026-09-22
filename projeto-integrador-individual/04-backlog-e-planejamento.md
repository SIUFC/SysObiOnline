# 04 - Backlog e planejamento

## Backlog funcional

### Produto

- API de autenticação e autorização.
- Cadastro e gestão de usuários.
- Cadastro, consulta e atualização de questões.
- Filtros por nível, fase e ano.
- Quiz e validação de respostas.
- Relatórios de desempenho.

### User stories

- Como aluno, quero me cadastrar para acessar o sistema.
- Como aluno, quero autenticar-me para usar a plataforma.
- Como administrador, quero criar questões para alimentar o banco de conteúdo.
- Como usuário, quero filtrar perguntas por categoria para estudar melhor.
- Como aluno, quero responder uma questão e receber feedback imediato.
- Como usuário, quero consultar meu histórico e desempenho.

## Planejamento sugerido

### Sprint 1 — base do sistema

- modelagem e setup do projeto;
- configuração do Banco de Dados;
- autenticação e cadastro de usuários.

### Sprint 2 — conteúdo e gestão de questões

- estrutura de `Question`;
- endpoints de criação e atualização;
- filtros por nível, ano e fase.

### Sprint 3 — quiz e relatórios

- lógica de resposta;
- persistência em `QuizResult` e `AnswerGiven`;
- cálculo de relatórios.

### Sprint 4 — refinamento e entrega

- correções de integração;
- documentação Swagger;
- validação final e apresentação.

## Critérios de entrega

- aplicação compilando sem erros fundamentais;
- API documentada e acessível;
- regras de negócio implementadas e testadas;
- relatório de status e riscos apresentado.

## Indicadores de sucesso

- usuários conseguem autenticar-se;
- questões são criadas e consultadas corretamente;
- respostas são validadas com precisão;
- relatórios refletem desempenho real.
