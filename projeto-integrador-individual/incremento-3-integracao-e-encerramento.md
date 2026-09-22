# Projeto Integrador Individual — Incremento 3

> **Disciplina:** Gestão de Projetos de Software  
> **Projeto:** SysObiOnline — plataforma de prática para a Olimpíada Brasileira de Informática (OBI)  
> **Gerente do projeto:** discente responsável  
> **Quadro GitHub Projects:** **[inserir aqui a URL do quadro antes da exportação para PDF]**

Este relatório consolida o planejamento dos Incrementos 1 e 2 e apresenta as práticas de integração, respostas a riscos, aquisições, métodos ágeis, mudanças e encerramento. Custos, indicadores e papéis representam uma simulação de gerenciamento do MVP, não dados de execução ou contratos reais.

## 1. Base do projeto e integração

O MVP do SysObiOnline concentra autenticação de usuários, autorização administrativa, catálogo e filtros de questões, envio e correção de respostas, relatório de desempenho e documentação Swagger. O gerenciamento adota uma abordagem **híbrida**: baselines de escopo, prazo e custo do PMI/PMBOK combinadas com execução incremental em Scrum.

| Artefato integrado | Decisão consolidada |
| --- | --- |
| Escopo | API REST, usuários, JWT, questões, filtros, quiz, relatórios, SQL Server e Swagger. |
| Exclusões do MVP | Aplicativo móvel, gamificação, pagamentos, IA, correção automática de código e SLA comercial 24x7. |
| Prazo-base | 43,50 dias úteis; caminho crítico: A → B → C → G → H → I → J. |
| Custo-base (BAC) | R$ 75.000,00. |
| Equipe | Gerente do Projeto, back-end, front-end, QA, UX/UI, DevOps e curador de conteúdo. |
| Governança | Patrocinador aprova baselines e mudanças relevantes; gerente integra planos, riscos, comunicação e decisões. |

O Project Management Plan será a referência única de integração. Toda mudança aprovada deve atualizar, quando aplicável, a baseline, o backlog, o cronograma, os custos, os riscos, os critérios de qualidade e o GitHub Projects.

## 2. Respostas aos riscos

| ID | Risco | Estratégia | Ação | Gatilho | Responsável | Monitoramento |
| --- | --- | --- | --- | --- | --- | --- |
| R01 | Requisitos ambíguos causam retrabalho. | Mitigar | Refinar histórias e validar critérios de aceite antes do desenvolvimento. | História devolvida ou aceite divergente. | Gerente do Projeto | Revisão semanal do Product Backlog. |
| R02 | Atraso no catálogo/filtros afeta o caminho crítico. | Mitigar | Dividir tarefas, limitar WIP e antecipar validação do curador. | Atividade G ultrapassa data-base. | Back-end | Daily Scrum e board diário. |
| R03 | Falha de autorização expõe funções administrativas. | Evitar | Revisar perfis, JWT e testes de rotas protegidas. | Usuário sem perfil acessa rota restrita. | Back-end e QA | Testes de segurança antes do aceite. |
| R04 | Dados ou relatórios ficam inconsistentes. | Mitigar | Criar cenários de teste e executar regressão após correção. | Divergência entre resposta persistida e relatório. | QA | Registro de defeitos e regressão. |
| R05 | Ambiente ou credenciais não são liberados. | Mitigar | Solicitar recursos antecipadamente e manter alternativa local. | Ambiente indisponível na data planejada. | DevOps | Checklist semanal. |
| R06 | Questões são classificadas incorretamente. | Mitigar | Aplicar dupla revisão e amostragem com o curador. | Curador reprova amostra. | Curador | Revisão por lote. |
| R07 | Custo permanece acima do previsto. | Mitigar | Analisar desvio, reestimar o restante e controlar horas. | CPI < 0,90 em duas medições. | Gerente do Projeto | EVM quinzenal. |
| R08 | Custo de ferramenta/infraestrutura aumenta. | Aceitar | Utilizar reserva de contingência após aprovação. | Aviso de reajuste. | DevOps e GP | Revisão mensal de custos. |

R01 e R02 são riscos altos e serão revistos semanalmente. O gerente deve escalar ao patrocinador riscos que ameacem a baseline ou os critérios de qualidade; a resposta deve ser atualizada no Risk Register com data, proprietário e evidência de acompanhamento.

## 3. Aquisições — Make-or-Buy

| Item | Decisão | Justificativa | Modelo de contratação |
| --- | --- | --- | --- |
| API, autenticação, quiz e relatórios | Make | Regras de negócio são específicas da OBI e compõem o núcleo do produto. | Equipe interna. |
| Hospedagem, banco gerenciado e domínio | Buy | Serviço especializado reduz esforço operacional e tempo de implantação. | Preço fixo mensal. |
| Monitoramento e logs | Buy/serviço gratuito | Não são diferencial do MVP; construir solução própria eleva custo e prazo. | Plano gratuito ou assinatura. |
| Curadoria de questões | Make com apoio especializado | A qualidade pedagógica e a taxonomia devem permanecer sob controle do projeto. | Hora técnica/tempo e material, se terceirizada. |
| GitHub Projects e Swagger | Uso de serviço existente | Atendem à rastreabilidade do trabalho e à documentação da API. | Plano existente ou gratuito. |

**Decisão:** utilizar preço fixo para serviços de escopo previsível, como domínio e hospedagem; utilizar tempo e material apenas para apoio especializado com demanda variável, como curadoria adicional. Contratos de custo reembolsável não são recomendados para o MVP, por reduzirem a previsibilidade do orçamento.

## 4. Project Charter — Carta do Projeto

### Identificação e justificativa

**Nome:** SysObiOnline — Plataforma de prática para a OBI.  
**Patrocinador:** Coordenação de Produtos Educacionais do Núcleo de Soluções Educacionais (cenário fictício).  
**Gerente do Projeto:** discente responsável.

Estudantes encontram questões da OBI em fontes dispersas e não contam com uma solução única para filtrar exercícios, responder questões e acompanhar desempenho. O projeto se justifica por centralizar o conteúdo e transformar a prática em uma experiência mensurável, segura e preparada para integração com frontend.

### Objetivo e entregáveis

Entregar um MVP que permita cadastro e autenticação, controle de acesso por perfil, gestão e filtros de questões, quiz, relatório individual e documentação de API. Os entregáveis são: API integrada, banco de dados configurado, regras de autenticação/autorização, endpoints documentados, evidências de testes, relatório de aceite e lições aprendidas.

### Premissas, restrições e sucesso

| Elemento | Definição |
| --- | --- |
| Premissas | Equipe planejada disponível conforme alocação; curador valida taxonomia; área de TI disponibiliza infraestrutura. |
| Restrições | BAC de R$ 75.000,00, prazo-base de 43,50 dias úteis e escopo limitado ao MVP. |
| Autoridade do GP | Priorizar atividades dentro da baseline, coordenar equipe e escalar impedimentos; não aprovar aumento relevante de custo ou escopo sem patrocinador. |
| Sucesso | Autenticação e autorização funcionais; questões filtradas corretamente; respostas avaliadas; relatório disponível; Swagger atualizado; aceite do patrocinador. |

O patrocinador autoriza o planejamento e aprova o Project Charter, as baselines e mudanças relevantes. A assinatura pode ser simulada no relatório acadêmico, mantendo a identificação de que se trata de cenário de planejamento.

## 5. Project Management Plan consolidado

| Área | Plano de gerenciamento |
| --- | --- |
| Integração | O gerente mantém coerência entre Charter, Business Case, baselines, mudanças, indicadores e encerramento. |
| Escopo | Requisitos, histórias de usuário, EAP e critérios de aceite definem o que está incluído; mudanças exigem Change Request. |
| Cronograma | PERT, PDM, CPM, marcos e baseline controlam as atividades; atrasos no caminho crítico exigem ação imediata. |
| Custos | BAC, Curva S e EVM são medidos quinzenalmente; uso da contingência requer justificativa. |
| Qualidade | Critérios de aceite, ISO/IEC 25010, testes de API, revisão e PDCA previnem e corrigem defeitos. |
| Recursos | Papéis, alocações e responsabilidades são controlados pelo gerente, com apoio de Tuckman e Belbin para colaboração. |
| Comunicação | GitHub Projects é a fonte de rastreabilidade; status ao patrocinador ocorre quinzenalmente; equipe acompanha diariamente. |
| Riscos | Risk Register, RBS e matriz P×I são atualizados; riscos altos são revisados semanalmente. |
| Aquisições | Decisões Make-or-Buy e tipo de contratação são avaliados contra custo, prazo, qualidade e risco. |
| Stakeholders | Patrocinador, curadores, alunos, equipe e área de TI são engajados conforme a matriz de engajamento. |

## 6. KPIs e rotina de monitoramento

| KPI | Fórmula/medição | Meta | Frequência | Responsável |
| --- | --- | --- | --- | --- |
| CPI | EV / AC | ≥ 1,00 | Quinzenal | Gerente do Projeto |
| SPI | EV / PV | ≥ 1,00 | Quinzenal | Gerente do Projeto |
| Taxa de aceite | Itens aceitos / itens entregues | ≥ 90% | Por Sprint | QA |
| Defeitos críticos abertos | Quantidade | 0 no aceite | Semanal | QA |
| Cobertura Swagger | Endpoints documentados / endpoints do MVP | 100% | Por release | Back-end |
| Tempo p95 de filtro | Percentil 95 de resposta | ≤ 500 ms | Por teste | QA e DevOps |
| Taxa de retorno | Usuários recorrentes / usuários ativos | Meta validada no piloto | Mensal | UX/UI |

### Rotina

* Atualizar status, responsáveis, prioridades, dependências e evidências no GitHub Projects diariamente.
* Realizar Daily Scrum durante a execução e Sprint Review/Retrospective no encerramento de cada Sprint.
* Revisar riscos altos semanalmente e os demais riscos no comitê quinzenal.
* Calcular EVM em cada marco relevante ou, no mínimo, quinzenalmente.
* Escalar ao patrocinador CPI ou SPI inferiores a 0,90 por duas medições consecutivas.

## 7. Controle integrado de mudanças

### Change Request simulado

**Solicitação:** incluir gamificação no MVP, com pontuação, ranking e medalhas para alunos.

| Área | Impacto analisado |
| --- | --- |
| Escopo | Inclui regras, persistência, endpoints, interface e critérios de aceite não previstos. |
| Prazo | Aumenta o caminho crítico por depender de quiz e relatório. |
| Custos | Exige horas adicionais de back-end, front-end, UX/UI e QA. |
| Qualidade | Amplia os cenários de teste e o risco de inconsistência de pontuação. |
| Recursos | Exige capacidade adicional de desenvolvimento e validação. |
| Riscos | Aumenta risco de atraso, estouro de orçamento e retrabalho. |

**Decisão:** adiar a solicitação para uma versão posterior ao MVP. A gamificação possui valor potencial, porém não é necessária para comprovar o objetivo central: acesso, filtros, respostas e relatórios. A inclusão imediata comprometeria escopo, prazo e orçamento aprovados.

### Fluxo de controle

1. Registrar o Change Request como issue com contexto e justificativa.
2. Analisar impacto em escopo, prazo, custo, qualidade, recursos e riscos.
3. Preparar recomendação de aprovação, rejeição ou adiamento.
4. Submeter a decisão relevante ao patrocinador.
5. Se aprovada, atualizar baselines, backlog, cronograma, orçamento, riscos e comunicação.
6. Registrar decisão e evidência no GitHub Projects.

## 8. Aplicação de Scrum

O projeto permanece híbrido: utiliza planejamento preditivo para governança e Scrum para desenvolver e validar incrementos de valor.

### Produto e backlog

**Epic:** Plataforma de prática e acompanhamento de desempenho para a OBI.

**Product Backlog priorizado:**

1. Cadastro, login e JWT.
2. Perfis e autorização administrativa.
3. Cadastro e atualização de questões.
4. Filtros por nível, ano e fase.
5. Envio e correção de respostas.
6. Relatório de desempenho.
7. Documentação Swagger.
8. Testes, demonstração e aceite.

### Sprints

| Sprint | Objetivo |
| --- | --- |
| Sprint 1 | Arquitetura, ambiente, cadastro, login e autorização. |
| Sprint 2 | Catálogo de questões, filtros e validação da taxonomia. |
| Sprint 3 | Quiz, correção de respostas e relatórios. |
| Sprint 4 | Testes, correções, Swagger, demonstração e aceite. |

No **Sprint Planning**, a equipe cria o Sprint Backlog a partir do Product Backlog priorizado. No **Daily Scrum**, identifica andamento, plano e impedimentos. A **Sprint Review** demonstra o incremento para patrocinador e curador. A **Sprint Retrospective** registra melhorias para o próximo ciclo.

### Definition of Done

Uma história está concluída quando atende aos critérios de aceite, possui testes executados, não tem defeito crítico aberto, mantém documentação atualizada quando aplicável, está demonstrada na Review e possui status/evidências atualizados no GitHub Projects.

## 9. Encerramento e lições aprendidas

### Checklist de encerramento

- [ ] Confirmar aceite de autenticação, autorização, catálogo, filtros, quiz e relatório.
- [ ] Confirmar documentação Swagger atualizada.
- [ ] Comparar prazo, custos e escopo com as baselines.
- [ ] Registrar defeitos conhecidos, pendências e riscos residuais.
- [ ] Atualizar todas as issues, milestones e evidências do GitHub Projects.
- [ ] Realizar retrospectiva final.
- [ ] Registrar lições aprendidas.
- [ ] Elaborar relatório de encerramento para o patrocinador.

### Lições aprendidas esperadas

1. Refinar requisitos e critérios de aceite antes da implementação reduz retrabalho.
2. Catálogo e filtros são componentes críticos para o valor do produto e para o cronograma.
3. A validação da taxonomia pelo curador deve ocorrer antes dos testes integrados.
4. Indicadores de Valor Agregado antecipam desvios de prazo e custo.
5. O GitHub Projects deve ser atualizado continuamente para preservar evidências de planejamento, execução e decisão.
