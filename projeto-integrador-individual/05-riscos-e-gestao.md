# 05 - Riscos e gestão

## Riscos técnicos

1. Problemas de conexão com SQL Server
   - risco: falhas de ambiente, strings de conexão incompatíveis ou ausência do banco.
   - mitigação: validar `appsettings.json`, conexão local ou por container, testar a conexão antes da execução.

2. Erros de autenticação JWT
   - risco: token inválido, configurações de issuer/audience/incorreta.
   - mitigação: validar as configurações em `Program.cs` e `appsettings.json`.

3. Defeitos de regra de negócio
   - risco: lógica de resposta incorreta ou cálculos de relatório inconsistentes.
   - mitigação: revisar endpoints de quiz e validar cenários com dados de teste.

4. Problemas de versionamento e revisão
   - risco: alterações incompatíveis entre branches ou arquivos.
   - mitigação: manter commits claros e revisar cada alteração antes do merge.

## Riscos de projeto

- escopo mal definido;
- requisitos incompletos;
- dependência de frontend para validação funcional;
- evolução do sistema sem documentação adequada.

## Estratégia de gestão

- manter backlog atualizado;
- registrar prioridades e critérios de aceitação;
- validar entregas por partes;
- divulgar avanços por sprint;
- armazenar decisões e alterações em documentação.

## Métricas esperadas

- tempo de autenticação;
- taxa de respostas corretas;
- número de questões realizadas por usuário;
- erros de API por endpoint;
- tempo de resposta da aplicação.

## Conclusão

A gestão do projeto deve priorizar qualidade de entrega, clareza de requisitos e validação contínua da funcionalidade, reduzindo riscos de falha operacional e de alinhamento com o escopo.
