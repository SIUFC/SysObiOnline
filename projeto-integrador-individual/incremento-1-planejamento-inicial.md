# Projeto Integrador Individual — Incremento 1

> **Disciplina:** Gestão de Projetos de Software  
> **Projeto:** SysObiOnline — plataforma de prática para a Olimpíada Brasileira de Informática (OBI)  
> **Gerente do projeto:** discente responsável  
> **Quadro GitHub Projects:** **[inserir aqui a URL do quadro antes da exportação para PDF]**

Este relatório reúne o planejamento solicitado para o Incremento 1. Os valores, equipe e organização apresentados são estimativas de um cenário de projeto; eles não descrevem custos ou contratos já realizados pelo repositório.

## 1. Identificação do projeto

| Item | Definição |
| --- | --- |
| Nome | **SysObiOnline** |
| Problema | Estudantes encontram questões da OBI em fontes dispersas e não dispõem de uma experiência centralizada para filtrar exercícios, responder questões e acompanhar o próprio desempenho. |
| Contexto | Produto educacional digital concebido para uma organização fictícia, o **Núcleo de Soluções Educacionais (NSE)**, que mantém plataformas de apoio ao ensino. O repositório existente fornece uma API ASP.NET Core como base técnica do produto. |
| Patrocinador | Coordenação de Produtos Educacionais do NSE. |
| Produto proposto | Uma API REST que sustente um frontend futuro: cadastro e autenticação, gestão de questões, filtros por nível/ano/fase, envio de respostas e relatório de desempenho. |
| Horizonte do planejamento | Cinco meses para a primeira versão utilizável (MVP), seguidos de cinco anos de análise financeira. |

### Objetivo geral

Planejar e conduzir a entrega de um MVP do SysObiOnline que centralize a prática de questões da OBI, permita identificar usuários com segurança e ofereça retorno mensurável sobre seu desempenho, dentro do prazo, orçamento e escopo aprovados.

### Objetivos específicos

1. Disponibilizar, até o encerramento do MVP, cadastro, autenticação baseada em JWT e perfis de acesso para aluno e administrador.
2. Permitir que administradores mantenham o catálogo de questões e que visitantes ou alunos consultem questões por nível, ano e fase.
3. Registrar a resposta do aluno, informar o resultado e consolidar indicadores de acertos, erros e questões respondidas.
4. Definir requisitos, fronteiras de escopo, estimativas, dependências e entregáveis verificáveis antes do início do desenvolvimento do MVP.
5. Planejar uma solução com qualidade, segurança e documentação de API suficientes para integração posterior com um frontend.
6. Monitorar a entrega por meio de marcos, indicadores e um quadro GitHub Projects com issues, responsáveis, prioridades e status atualizados.

### Benefícios esperados e critérios de sucesso

* **Educacional:** conteúdo organizado e prática orientada por filtros, reduzindo o esforço de localizar questões.
* **Para o usuário:** feedback imediato e visualização de desempenho para orientar o estudo.
* **Operacional:** um único catálogo administrável, com controle de acesso e API documentada.
* **Critérios de sucesso do MVP:** autenticação funcional; criação e consulta de questões; resposta avaliada corretamente; relatório individual disponível; e documentação Swagger acessível no ambiente de desenvolvimento.

## 2. Abordagem e ciclo de vida

Foi escolhido um **ciclo de vida híbrido, iterativo-incremental**. O planejamento inicial usa práticas preditivas do PMI/PMBOK — escopo, EAP, estimativas, orçamento, marcos e baseline — porque o MVP possui entregáveis e restrições claramente identificáveis. A construção e a validação do catálogo, quiz e relatórios ocorrerão em incrementos curtos, com priorização contínua do backlog.

Essa escolha reduz o risco de implementar funcionalidades de baixo valor antes de validar o fluxo de estudo. Ela também preserva previsibilidade para aprovação do escopo e do investimento. Cada incremento terá uma demonstração do produto, revisão dos requisitos e atualização controlada do backlog; mudanças após a baseline serão submetidas ao controle integrado de mudanças.

## 3. Stakeholders

### 3.1 Stakeholder Register

| Stakeholder | Interesse e expectativa | Poder/influência | Estratégia e responsável |
| --- | --- | --- | --- |
| Patrocinador — Coordenação de Produtos Educacionais | Retorno educacional, orçamento e entrega do MVP | Alto | Gerenciar de perto; gerente do projeto apresenta status quinzenal. |
| Gerente do Projeto | Cumprir escopo, prazo, custo e comunicação | Alto | Coordenar planejamento, riscos, mudanças e board. |
| Alunos usuários | Encontrar questões, praticar e receber feedback claro | Médio | Consultar em entrevistas e validar protótipos; responsável: UX/UI. |
| Professores/curadores OBI | Qualidade e classificação adequada das questões | Alto | Validar conteúdo e critérios de catalogação; responsável: analista de requisitos. |
| Administrador de conteúdo | Cadastrar, corrigir e manter questões | Médio | Envolver nos critérios de aceitação e testes de gestão. |
| Equipe técnica (desenvolvimento, QA, UX/UI e DevOps) | Requisitos claros, ambiente e decisões tempestivas | Médio | Comunicação diária de execução; responsável: gerente do projeto. |
| Instituição/área de TI do NSE | Segurança, disponibilidade e conformidade | Alto | Consultar antes de decisões de infraestrutura; responsável: DevOps. |

### 3.2 Modelo de Saliência de Mitchell, Agle e Wood

| Stakeholder | Poder | Legitimidade | Urgência | Classe de saliência | Tratamento |
| --- | --- | --- | --- | --- | --- |
| Patrocinador | Sim | Sim | Sim | Definitivo | Decisões e escalonamentos imediatos. |
| Professores/curadores | Sim | Sim | Não | Dominante | Participação nas aprovações de conteúdo. |
| Área de TI | Sim | Sim | Não | Dominante | Consulta obrigatória sobre segurança e operação. |
| Alunos | Não | Sim | Sim | Dependente | Coletar evidências de uso e priorizar necessidades. |
| Administrador de conteúdo | Não | Sim | Sim | Dependente | Validar fluxo administrativo antes da liberação. |
| Equipe técnica | Sim | Sim | Sim | Definitivo no nível operacional | Remover impedimentos e garantir capacidade de entrega. |

### 3.3 Matriz de engajamento

| Stakeholder | Estado atual | Estado desejado | Ação de engajamento |
| --- | --- | --- | --- |
| Patrocinador | Favorável | Líder | Comitê quinzenal com decisões registradas. |
| Professores/curadores | Neutro | Favorável | Oficina de requisitos e aceite da taxonomia. |
| Alunos | Neutro | Favorável | Entrevistas, teste de protótipo e formulário de feedback. |
| Administrador de conteúdo | Neutro | Líder | Demonstração do fluxo de manutenção e roteiro de aceite. |
| Área de TI | Neutro | Favorável | Revisão de arquitetura, segurança e implantação. |
| Equipe técnica | Favorável | Líder | Planejamento colaborativo e quadro de trabalho visível. |

## 4. Contexto organizacional e governança

O NSE adota uma estrutura **matricial balanceada**: os profissionais pertencem às áreas funcionais (tecnologia, conteúdo e design), mas são alocados temporariamente ao SysObiOnline. O patrocinador aprova o Business Case, o orçamento e mudanças relevantes; o gerente do projeto possui autoridade para priorizar o trabalho dentro da baseline, distribuir atividades e escalar impedimentos, mas não para alterar orçamento ou escopo aprovado sem decisão do patrocinador.

Um **PMO de suporte** padronizaria templates, indicadores, governança de riscos, lições aprendidas e auditoria das baselines. Não tomaria a decisão diária do produto, mas aumentaria a consistência do planejamento e a rastreabilidade das decisões.

## 5. Business Case

### Problema, oportunidade e justificativa

Há oportunidade de transformar conteúdo educacional disperso em uma experiência digital consultável e mensurável. O projeto se justifica se o benefício educacional e a economia de curadoria/retrabalho superarem o investimento do MVP, mantendo os riscos de segurança e qualidade de conteúdo em níveis aceitáveis.

### Alternativas avaliadas

| Alternativa | Decisão | Justificativa |
| --- | --- | --- |
| Manter materiais dispersos | Rejeitada | Não oferece histórico, filtros padronizados nem controle de acesso. |
| Adquirir plataforma genérica de quiz | Rejeitada para o MVP | Pode exigir adaptações e não garante a taxonomia específica da OBI. |
| Evoluir o SysObiOnline | Recomendada | Reaproveita a base de API existente e permite ajustar o produto ao contexto educacional. |

### Investimento, custos e benefícios estimados

O investimento inicial planejado é de **R$ 75.000**, composto por desenvolvimento e QA (R$ 42.000), UX/UI e levantamento (R$ 12.000), infraestrutura/configuração (R$ 8.000), curadoria inicial (R$ 8.000) e reserva de contingência (R$ 5.000). Os fluxos de caixa líquidos abaixo já consideram custos recorrentes de infraestrutura, suporte e curadoria e benefícios estimados por assinaturas/parcerias e redução de trabalho manual.

| Ano | Fluxo de caixa líquido (R$) | Fluxo acumulado (R$) |
| --- | ---: | ---: |
| 0 — investimento | -75.000 | -75.000 |
| 1 | 28.000 | -47.000 |
| 2 | 34.000 | -13.000 |
| 3 | 40.000 | 27.000 |
| 4 | 46.000 | 73.000 |
| 5 | 50.000 | 123.000 |

Principais riscos do caso: baixa adesão de usuários, conteúdo classificado incorretamente, indisponibilidade do banco de dados e falhas de segurança. A decisão recomendada é aprovar o planejamento do MVP, condicionada à validação de conteúdo pelos curadores e à aprovação do orçamento pelo patrocinador.

## 6. Viabilidade financeira

Premissas: horizonte de cinco anos, taxa mínima de atratividade (TMA) de **12% ao ano**, fluxos anuais ao fim de cada ano e valores sem inflação. A análise é de viabilidade, não uma projeção contábil.

| Indicador | Cálculo/resultado | Interpretação |
| --- | --- | --- |
| VPL | \(\sum_{t=0}^{5} FC_t/(1+0,12)^t = \textbf{R$ 63.180,98}\) | Positivo; o retorno projetado excede a TMA. |
| TIR | **38,72% a.a.** | Superior à TMA de 12%; o investimento é atrativo sob as premissas. |
| Payback simples | **2,33 anos** (aprox. 2 anos e 4 meses) | O fluxo acumulado torna-se positivo durante o terceiro ano. |

Assim, a viabilidade financeira é favorável. A aprovação não deve depender apenas desses indicadores: a equipe revisará semestralmente a adoção e os custos recorrentes, pois a materialização dos benefícios depende do uso real da plataforma.

## 7. Alinhamento estratégico — Balanced Scorecard

| Perspectiva | Objetivo estratégico do NSE | Contribuição do SysObiOnline | Indicador inicial |
| --- | --- | --- | --- |
| Financeira | Sustentar produtos educacionais digitais | Reduzir retrabalho de curadoria e criar potencial de parceria/receita | custo mensal por usuário ativo; fluxo de caixa líquido. |
| Clientes | Melhorar a experiência de aprendizagem | Prática organizada e feedback após a resposta | satisfação do aluno; taxa de retorno. |
| Processos internos | Padronizar a gestão do conteúdo | Catálogo com filtros, perfis e fluxo administrativo | percentual de questões classificadas e revisadas. |
| Aprendizado e crescimento | Ampliar a capacidade digital da organização | Documentação, métricas e conhecimento de produto educacional | cobertura de documentação; lições aprendidas registradas. |

## 8. Requisitos, fronteiras de escopo e EAP

### 8.1 Requisitos prioritários

| ID | Tipo | Requisito | Critério de aceitação resumido |
| --- | --- | --- | --- |
| RF-01 | Funcional | Cadastrar e autenticar usuários. | Usuário válido recebe token JWT; senha não é armazenada em texto puro. |
| RF-02 | Funcional | Manter questões por administrador. | Administrador autorizado cria e atualiza uma questão com seus atributos. |
| RF-03 | Funcional | Filtrar questões por nível, ano e fase. | Filtro retorna apenas questões compatíveis ou informa que não há resultado. |
| RF-04 | Funcional | Registrar e avaliar resposta. | Sistema devolve o resultado e persiste o histórico associado ao usuário. |
| RF-05 | Funcional | Exibir relatório individual. | Relatório consolida acertos, erros e quantidade respondida. |
| RNF-01 | Não funcional | Proteger acesso. | Rotas restritas exigem JWT válido e perfis são respeitados. |
| RNF-02 | Não funcional | Manter a API documentada. | Endpoints e contratos são verificáveis no Swagger. |
| RNF-03 | Não funcional | Garantir manutenibilidade. | Solução preserva separação entre controllers, services, repositories e persistência. |

### 8.2 Histórias de usuário

* Como **aluno**, quero filtrar questões por nível, ano e fase para selecionar exercícios adequados ao meu estudo.
* Como **aluno autenticado**, quero enviar uma resposta e receber feedback para identificar meu desempenho.
* Como **aluno autenticado**, quero consultar meu relatório para acompanhar acertos e erros.
* Como **administrador**, quero criar e atualizar questões para manter o catálogo confiável.
* Como **curador**, quero validar a classificação das questões para que os filtros retornem conteúdo coerente.

### 8.3 Fronteiras do escopo

**Incluído no MVP:** API, autenticação, usuários, catálogo de questões, filtros, quiz, relatório, persistência SQL Server, documentação Swagger e preparação para integração com frontend.

**Excluído do MVP:** aplicativo móvel nativo, correção automática de código de programação, gamificação, recomendação por inteligência artificial, pagamentos, integração com redes sociais, migração completa de acervos externos e operação 24x7 com SLA comercial. Itens excluídos só entram por Change Request aprovado.

### 8.4 EAP/WBS e dicionário da EAP

| Código | Pacote de trabalho | Entregável e critério de conclusão |
| --- | --- | --- |
| 1.0 | Gerenciamento do projeto | Plano, baseline, riscos e status aprovados pelo patrocinador. |
| 1.1 | Iniciação | Business Case e registro de stakeholders aprovados. |
| 1.2 | Planejamento | EAP, requisitos, estimativas e cronograma-base publicados. |
| 2.0 | Produto SysObiOnline | MVP integrado e demonstrável. |
| 2.1 | Identidade e acesso | Cadastro, autenticação JWT e autorização testados. |
| 2.2 | Catálogo de questões | CRUD administrativo e filtros com dados de teste. |
| 2.3 | Quiz e relatórios | Respostas registradas, avaliadas e reportadas ao usuário. |
| 2.4 | Qualidade e documentação | Testes planejados/executados e Swagger atualizado. |
| 3.0 | Implantação e encerramento | Ambiente preparado, demonstração, aceite e lições aprendidas. |

## 9. Planejamento inicial das atividades e dependências

| ID | Atividade | Predecessora | Tipo de dependência | Marco/resultado |
| --- | --- | --- | --- | --- |
| A1 | Aprovar Business Case e Project Charter inicial | — | — | Autorização para planejar. |
| A2 | Levantar e priorizar requisitos | A1 | Obrigatória — término-início | Backlog priorizado. |
| A3 | Definir arquitetura e modelo de dados | A2 | Obrigatória — término-início | Decisão técnica registrada. |
| A4 | Projetar UX e critérios de aceite | A2 | Arbitrada — término-início | Fluxos validados. |
| A5 | Implementar identidade e acesso | A3 | Obrigatória — término-início | Autenticação disponível. |
| A6 | Implementar catálogo e filtros | A3, A4 | Obrigatória — término-início | Consulta de questões disponível. |
| A7 | Implementar quiz e relatório | A5, A6 | Obrigatória — término-início | Fluxo de estudo completo. |
| A8 | Testar, documentar e demonstrar | A7 | Obrigatória — término-início | MVP candidato ao aceite. |
| A9 | Disponibilizar ambiente e credenciais | A3 | Externa — término-início | Dependência da área de TI. |

As dependências **obrigatórias** decorrem da lógica técnica; a dependência **arbitrada** (A4 antes de A6) foi definida para reduzir retrabalho na interface futura; e a dependência **externa** (A9) depende da área de TI. O diagrama PDM deverá representar relações término-início entre as atividades acima no cronograma do Incremento 2.

## 10. Estimativa de esforço — Planning Poker

Como o escopo ainda é de MVP e as histórias são apropriadas a uma equipe ágil, foi adotado **Planning Poker** com a sequência de Fibonacci. A estimativa relativa é preferível a APF nesta fase porque há incerteza sobre o volume e a qualidade do acervo inicial; a velocidade será calibrada após o primeiro incremento de desenvolvimento.

| Item do Product Backlog | Pontos | Justificativa |
| --- | ---: | --- |
| Cadastro, login e JWT | 8 | Integra regras de segurança, persistência e contrato de API. |
| Perfis e autorização administrativa | 5 | Depende de regras de acesso e validação de rotas. |
| Cadastro/atualização de questões | 8 | Exige validações e modelo de dados de conteúdo. |
| Filtros de questões | 5 | Depende da taxonomia e de consultas persistidas. |
| Envio e correção de resposta | 8 | Combina regra de negócio, histórico e retorno ao aluno. |
| Relatório de desempenho | 5 | Consolida dados de respostas e indicadores. |
| Swagger, testes e demonstração | 5 | Inclui documentação e validação de aceite. |
| **Total** | **44** | — |

Com uma velocidade inicial planejada de **11 pontos por sprint de duas semanas**, o backlog do MVP demanda aproximadamente **quatro sprints** (oito semanas), acrescidos de duas semanas para iniciação, integrações, aceite e reserva. As estimativas serão revistas ao fim de cada Sprint Review; alteração de escopo, prazo ou orçamento será tratada como risco ou Change Request, conforme o caso.

## Próximos passos e evidências no GitHub Projects

Antes da entrega, o gerente do projeto deve criar o board, adicionar o link real na primeira página deste relatório e registrar as atividades A1–A9 como issues. Cada issue deverá possuir responsável, prioridade, status e milestone do Incremento 1. O board deverá ser atualizado progressivamente — e não apenas no momento da entrega — para preservar o histórico solicitado pela disciplina.
