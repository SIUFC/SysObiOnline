# Projeto Integrador Individual — Incremento 2

> **Disciplina:** Gestão de Projetos de Software  
> **Projeto:** SysObiOnline — plataforma de prática para a Olimpíada Brasileira de Informática (OBI)  
> **Gerente do projeto:** discente responsável  
> **Quadro GitHub Projects:** **[inserir aqui a URL do quadro antes da exportação para PDF]**

Este documento continua o planejamento do Incremento 1. As durações, custos, indicadores e estrutura de equipe representam uma simulação de gerenciamento para o MVP; não são dados de execução do repositório nem contratos reais.

## 1. Premissas de planejamento

* O MVP compreende autenticação, gestão e filtro de questões, envio/correção de respostas, relatório de desempenho e documentação da API.
* O calendário usa dias úteis de segunda a sexta, oito horas por dia, sem feriados, e considera uma janela de **23/09/2026 a 23/11/2026**.
* As estimativas PERT foram produzidas com a fórmula \(t_e=(O+4M+P)/6\), em que **O** é otimista, **M** é mais provável e **P** é pessimista.
* A baseline de prazo e custo será aprovada pelo patrocinador após a revisão deste Incremento. Alterações posteriores serão avaliadas pelo controle integrado de mudanças.

## 2. Cronograma

### 2.1 Estimativas PERT e PDM

| ID | Atividade | O | M | P | Duração PERT (dias) | Predecessora(s) PDM |
| --- | --- | ---: | ---: | ---: | ---: | --- |
| A | Iniciação e aprovação do planejamento | 2 | 3 | 5 | 3,17 | — |
| B | Levantamento e priorização de requisitos | 4 | 6 | 10 | 6,33 | A (TI) |
| C | Arquitetura e modelo de dados | 3 | 5 | 7 | 5,00 | B (TI) |
| D | UX e critérios de aceitação | 3 | 4 | 6 | 4,17 | B (TI) |
| E | Preparação de ambiente | 2 | 3 | 5 | 3,17 | C (TI) |
| F | Identidade, acesso e autorização | 5 | 7 | 11 | 7,33 | C (TI) |
| G | Catálogo de questões e filtros | 7 | 10 | 15 | 10,33 | C e D (TI) |
| H | Quiz, correção e relatórios | 6 | 9 | 14 | 9,33 | F e G (TI) |
| I | Testes integrados e correções | 4 | 6 | 9 | 6,17 | E e H (TI) |
| J | Documentação, demonstração e aceite | 2 | 3 | 5 | 3,17 | I (TI) |

**Legenda:** TI = término–início. As relações são obrigatórias, exceto D antes de G, que é uma dependência arbitrada para reduzir retrabalho no contrato que atenderá o frontend. A preparação de ambiente (E) também possui dependência externa da área de TI para disponibilizar infraestrutura e credenciais.

### 2.2 Rede PDM e CPM

```text
A → B → C ─┬→ E ──────────┐
           ├→ F ───────┐  │
           └→ G ← D ←──┘  │
                    ↓     │
                    H ───→ I → J
```

O **caminho crítico** é **A → B → C → G → H → I → J**, com duração esperada de **43,50 dias úteis**. A atividade D termina antes de C e possui folga aproximada de 0,83 dia; F possui folga aproximada de 3,00 dias; E possui folga aproximada de 16,50 dias. Essas folgas não autorizam mudança de escopo: elas apenas indicam a margem de atraso antes de afetar o marco final.

Qualquer atraso em A, B, C, G, H, I ou J desloca diretamente o término do MVP, pois essas atividades não têm folga. Por exemplo, um atraso de três dias em G posterga H, os testes integrados e o aceite em três dias, a menos que o patrocinador aprove compressão de cronograma (fast tracking ou crashing), com o risco correspondente de retrabalho, custo adicional ou queda de qualidade.

### 2.3 Cronograma-base

| Atividade | Início-base | Fim-base | Marco de controle |
| --- | --- | --- | --- |
| A — Iniciação | 23/09/2026 | 25/09/2026 | planejamento autorizado |
| B — Requisitos | 28/09/2026 | 06/10/2026 | backlog priorizado |
| C — Arquitetura | 07/10/2026 | 13/10/2026 | arquitetura aprovada |
| D — UX/aceite | 07/10/2026 | 12/10/2026 | critérios de aceite definidos |
| E — Ambiente | 14/10/2026 | 16/10/2026 | ambiente disponível |
| F — Identidade e acesso | 14/10/2026 | 23/10/2026 | autenticação validada |
| G — Catálogo e filtros | 14/10/2026 | 28/10/2026 | consulta de questões validada |
| H — Quiz e relatórios | 29/10/2026 | 10/11/2026 | fluxo de estudo integrado |
| I — Testes integrados | 11/11/2026 | 18/11/2026 | candidato ao aceite |
| J — Documentação e aceite | 19/11/2026 | 23/11/2026 | MVP aceito |

A tabela constitui a **baseline de cronograma** proposta. O GitHub Projects deve conter uma issue para cada atividade, as dependências registradas na descrição e milestones compatíveis com os marcos acima.

## 3. Custos e orçamento

### 3.1 Estimativa bottom-up

A estimativa bottom-up de mão de obra parte das horas planejadas por papel e da taxa-hora carregada (remuneração, encargos e custos indiretos estimados). Ela é adequada porque o projeto possui pacotes de trabalho já definidos na EAP.

| Recurso/pacote | Horas | Taxa (R$/h) | Custo (R$) |
| --- | ---: | ---: | ---: |
| Gerente do Projeto | 80 | 85,00 | 6.800,00 |
| Desenvolvedor back-end | 280 | 90,00 | 25.200,00 |
| Desenvolvedor front-end | 200 | 70,00 | 14.000,00 |
| QA | 140 | 65,00 | 9.100,00 |
| UX/UI | 80 | 70,00 | 5.600,00 |
| DevOps | 48 | 85,00 | 4.080,00 |
| Curador de conteúdo | 80 | 55,00 | 4.400,00 |
| **Subtotal de mão de obra** | **908** | — | **69.180,00** |
| Infraestrutura, ferramentas e domínio | — | — | 2.800,00 |
| Reserva de contingência | — | — | 3.020,00 |
| **Orçamento no término (BAC)** | — | — | **75.000,00** |

Como validação, a estimativa **paramétrica** usa os 44 pontos do Product Backlog definidos no Incremento 1 e uma referência de R$ 1.640 por ponto: **44 × R$ 1.640 = R$ 72.160**. A diferença de 4,31% frente ao subtotal bottom-up de mão de obra é aceitável nesta fase e é explicada pela composição distinta de papéis e pelo arredondamento da produtividade histórica. A reserva de contingência não financia novo escopo; seu uso requer registro do risco materializado e aprovação do gerente do projeto.

### 3.2 Curva S de custos

| Semana | Percentual planejado | PV semanal (R$) | PV acumulado (R$) | Percentual acumulado |
| --- | ---: | ---: | ---: | ---: |
| 1 | 8% | 6.000,00 | 6.000,00 | 8% |
| 2 | 12% | 9.000,00 | 15.000,00 | 20% |
| 3 | 16% | 12.000,00 | 27.000,00 | 36% |
| 4 | 18% | 13.500,00 | 40.500,00 | 54% |
| 5 | 18% | 13.500,00 | 54.000,00 | 72% |
| 6 | 14% | 10.500,00 | 64.500,00 | 86% |
| 7 | 9% | 6.750,00 | 71.250,00 | 95% |
| 8 | 5% | 3.750,00 | 75.000,00 | 100% |

A Curva S é formada pela coluna de PV acumulado. A concentração entre as semanas 3 e 6 é coerente com a construção das funcionalidades de maior esforço (catálogo, filtros, quiz e relatórios), seguida por testes e aceite.

## 4. Monitoramento — valor agregado (situação simulada)

**Ponto de medição:** fim da semana 4. O BAC é R$ 75.000,00. Pela baseline, deveriam estar concluídos 54% do trabalho; a medição simulada apurou 48% concluído e custo real de R$ 42.000,00.

| Métrica | Fórmula | Resultado | Leitura gerencial |
| --- | --- | ---: | --- |
| PV (Planned Value) | 54% × BAC | R$ 40.500,00 | Valor do trabalho que deveria estar concluído. |
| EV (Earned Value) | 48% × BAC | R$ 36.000,00 | Valor do trabalho efetivamente concluído e aceito. |
| AC (Actual Cost) | custos incorridos | R$ 42.000,00 | Custo consumido até a data de status. |
| CV | EV − AC | -R$ 6.000,00 | Há estouro de custo no trabalho realizado. |
| SV | EV − PV | -R$ 4.500,00 | A entrega está abaixo da linha de base do prazo. |
| CPI | EV / AC | 0,86 | Cada R$ 1,00 gasto gera R$ 0,86 de valor. |
| SPI | EV / PV | 0,89 | O ritmo é 11% inferior ao planejado. |
| EAC | BAC / CPI | R$ 87.500,00 | Mantido o desempenho de custos, prevê-se superar o orçamento. |
| ETC | EAC − AC | R$ 45.500,00 | Custo adicional esperado para concluir o trabalho. |
| VAC | BAC − EAC | -R$ 12.500,00 | Desvio final estimado desfavorável. |
| TCPI (para BAC) | (BAC − EV) / (BAC − AC) | 1,18 | Para cumprir o BAC, o restante teria de render R$ 1,18 por real gasto. |

O CPI e o SPI inferiores a 1 exigem ação corretiva, mas não justificam sacrificar segurança ou testes. O gerente deve analisar as causas do retrabalho em catálogo/quiz, priorizar a remoção de impedimentos, limitar trabalho em progresso e reestimar as histórias restantes. Como o TCPI de 1,18 é significativamente superior ao CPI atual de 0,86, cumprir o BAC é pouco provável sem redução aprovada de escopo, aumento de eficiência comprovado ou aporte adicional. A decisão deve ser registrada no comitê com o patrocinador.

## 5. Gestão da qualidade

### 5.1 Critérios de qualidade, aceitação e métricas

| Área | Critério de aceitação | Métrica e meta | Evidência/responsável |
| --- | --- | --- | --- |
| Autenticação | Credencial válida gera JWT; inválida não concede acesso. | 100% dos cenários críticos de autenticação aprovados. | Teste de API; QA. |
| Autorização | Rotas administrativas recusam usuário sem perfil adequado. | 0 acessos indevidos nos testes de autorização. | Teste de segurança; QA/back-end. |
| Catálogo e filtro | Retorno respeita nível, ano e fase informados. | 100% dos casos de aceite prioritários aprovados. | Casos de teste com massa curada; QA/curador. |
| Quiz e relatório | Resultado e indicadores correspondem às respostas persistidas. | 100% dos cálculos de cenários de teste conferidos. | Teste de regra de negócio; QA. |
| Desempenho | Consulta de filtro responde em tempo adequado no ambiente de teste. | p95 menor ou igual a 500 ms para massa de teste acordada. | Teste de desempenho; QA/DevOps. |
| Documentação | Contratos dos endpoints estão compreensíveis e atualizados. | 100% dos endpoints do MVP descritos no Swagger. | Revisão de API; back-end. |

### 5.2 ISO/IEC 25010 aplicada ao MVP

| Característica | Aplicação no SysObiOnline |
| --- | --- |
| Adequação funcional | Requisitos de cadastro, catálogo, quiz e relatório devem produzir resultados corretos e completos. |
| Eficiência de desempenho | Filtros e relatórios devem responder dentro da meta acordada para a carga de teste. |
| Compatibilidade | A API REST documentada deve permitir consumo consistente pelo frontend planejado. |
| Usabilidade | Contratos e mensagens devem ser claros para facilitar a interface e reduzir erros do usuário. |
| Confiabilidade | Dados de respostas e relatórios não podem ser perdidos ou inconsistentes após operações normais. |
| Segurança | JWT, hash de senha, validação de token e autorização por perfil protegem funções sensíveis. |
| Manutenibilidade | Separação entre controllers, services, repositories e persistência favorece análise e modificação. |

### 5.3 PDCA, prevenção e correção

| Etapa | Aplicação | Resultado esperado |
| --- | --- | --- |
| **Plan** | Definir requisitos, critérios de aceite, riscos, metas e plano de testes. | Prevenir ambiguidade e retrabalho. |
| **Do** | Implementar em incrementos pequenos, revisar código e manter documentação de API. | Entregar funcionalidade rastreável. |
| **Check** | Executar testes de API, revisar métricas e comparar PV/EV/AC com a baseline. | Detectar defeitos e desvios cedo. |
| **Act** | Registrar causa-raiz, corrigir, testar regressão e atualizar processo/backlog. | Evitar recorrência e aperfeiçoar o plano. |

As ações preventivas incluem definição de pronto (Definition of Done), revisão por pares, massa de dados validada pelo curador e validação de autorização em todas as rotas sensíveis. Ao detectar um defeito, o QA abre issue com evidência, severidade e critério de reprodução; o responsável corrige, o QA executa regressão e o gerente avalia impacto em prazo, custo e risco.

## 6. Recursos e equipe planejada

| Papel | Responsabilidades no projeto | Alocação estimada |
| --- | --- | ---: |
| Gerente do Projeto | Planejamento, baseline, riscos, comunicação, indicadores e escalonamento. | 80 h |
| Desenvolvedor back-end | API, regras de negócio, persistência, autenticação e integração. | 280 h |
| Desenvolvedor front-end | Interface consumidora e validação de integração planejada. | 200 h |
| QA | Estratégia e execução de testes, evidências e acompanhamento de defeitos. | 140 h |
| UX/UI | Fluxos, protótipos, acessibilidade e critérios de experiência. | 80 h |
| DevOps | Ambiente, pipeline, observabilidade básica e apoio à implantação. | 48 h |
| Curador de conteúdo | Taxonomia, qualidade e validação das questões da OBI. | 80 h |

O time possui **sete integrantes**, além do patrocinador como stakeholder externo. No modelo de Tuckman, o gerente promove: *forming* com kick-off, papéis e objetivos; *storming* com regras de decisão e mediação de conflitos; *norming* com Definition of Done e ritos de acompanhamento; e *performing* com entrega e melhoria contínua. Pela lente de Belbin, as funções predominantes são: gerente como **Coordenador/Monitor Avaliador**, back-end como **Especialista/Implementador**, QA como **Finalizador**, UX/UI como **Criativo**, DevOps como **Implementador** e curador como **Especialista**. A classificação orienta a colaboração; não substitui definição formal de responsabilidade.

## 7. Plano de comunicação

| Stakeholder | Informação | Responsável | Canal | Periodicidade |
| --- | --- | --- | --- | --- |
| Patrocinador | Status, marcos, EVM, riscos e decisões requeridas | Gerente do Projeto | Reunião e resumo por e-mail | Quinzenal e por exceção |
| Equipe do projeto | Prioridades, impedimentos, dependências e tarefas | Gerente do Projeto | GitHub Projects e reunião curta | Diário em execução; board contínuo |
| Professores/curadores | Taxonomia, qualidade do acervo e critérios de aceite | Analista/gerente e curador | Oficina e issues | Semanal durante catálogo |
| Alunos representantes | Fluxos, clareza do feedback e retorno de teste | UX/UI | Protótipo/formulário | A cada incremento relevante |
| Área de TI | Ambiente, segurança, credenciais e implantação | DevOps | Ticket e reunião técnica | Semanal ou por mudança |
| QA e desenvolvimento | Defeitos, evidências de teste e correções | QA | Issues vinculadas a pull requests | Contínuo |

Com sete integrantes de equipe, existem \(n(n-1)/2 = 7(6)/2 = \textbf{21}\) canais potenciais de comunicação. Se a equipe crescer para dez integrantes, serão \(10(9)/2 = \textbf{45}\) canais, mais que o dobro. Por isso, o projeto centraliza decisões, requisitos, riscos e status no GitHub Projects; restringe reuniões a participantes necessários; e utiliza o gerente como ponto de consolidação para o patrocinador. A comunicação registrada não elimina contato direto, mas reduz perda de informação e ruído.

## 8. Gestão de riscos

### 8.1 RBS — Estrutura Analítica de Riscos

```text
1. Técnico
   1.1 Segurança e autenticação
   1.2 Banco de dados, desempenho e disponibilidade
   1.3 Integração e qualidade de software
2. Projeto
   2.1 Escopo, estimativas e cronograma
   2.2 Pessoas, comunicação e conhecimento
3. Produto e conteúdo
   3.1 Qualidade/classificação das questões
   3.2 Adoção e experiência do usuário
4. Externo
   4.1 Infraestrutura e credenciais da área de TI
   4.2 Mudança em dependências ou políticas institucionais
```

### 8.2 Risk Register e matriz probabilidade × impacto

Escala: probabilidade (P) e impacto (I) de 1 a 5; exposição = P × I. Prioridade: **alta** (15–25), **média** (8–14) e **baixa** (1–7).

| ID | Risco | Categoria | P | I | Exposição | Prioridade | Gatilho | Proprietário | Resposta inicial |
| --- | --- | --- | ---: | ---: | ---: | --- | --- | --- | --- |
| R01 | Requisitos ambíguos causam retrabalho. | Projeto/escopo | 4 | 4 | 16 | Alta | História devolvida ou aceite divergente. | Gerente do Projeto | Mitigar com refinamento e critérios de aceite. |
| R02 | Atraso no catálogo/filtros afeta o caminho crítico. | Projeto/prazo | 3 | 5 | 15 | Alta | G ultrapassa a data-base. | Back-end | Mitigar com acompanhamento diário e divisão de tarefas. |
| R03 | Falha de autorização expõe função administrativa. | Técnico/segurança | 2 | 5 | 10 | Média | Teste acessa rota indevida. | Back-end | Evitar com testes de perfil e revisão de código. |
| R04 | Dados ou relatórios ficam inconsistentes. | Técnico/qualidade | 3 | 4 | 12 | Média | Divergência em cenário de teste. | QA | Mitigar com testes de regra e regressão. |
| R05 | Infraestrutura/credenciais não são liberadas. | Externo | 3 | 4 | 12 | Média | Ambiente indisponível na data de E. | DevOps | Mitigar com solicitação antecipada e ambiente alternativo. |
| R06 | Questões são classificadas incorretamente. | Produto/conteúdo | 3 | 4 | 12 | Média | Curador reprova amostra. | Curador | Mitigar com dupla revisão e taxonomia definida. |
| R07 | Custo real permanece acima do valor agregado. | Projeto/custo | 3 | 4 | 12 | Média | CPI menor que 0,90 em duas medições. | Gerente do Projeto | Mitigar com análise de causa e replanejamento. |
| R08 | Ausência de pessoa-chave interrompe atividade. | Projeto/pessoas | 2 | 4 | 8 | Média | Indisponibilidade superior a dois dias úteis. | Gerente do Projeto | Mitigar com documentação e pareamento. |
| R09 | Baixa adesão reduz os benefícios esperados. | Produto/adoção | 2 | 4 | 8 | Média | Feedback negativo ou baixa taxa de retorno. | UX/UI | Mitigar com teste de usabilidade e iteração. |
| R10 | Mudança de pacote/infraestrutura eleva custo. | Externo | 2 | 3 | 6 | Baixa | Aviso de fornecedor ou área de TI. | DevOps | Aceitar com monitoramento e reserva. |

Na matriz, R01 e R02 ocupam a zona vermelha (alta prioridade); R03 a R09 formam a zona amarela; R10 permanece em zona verde. Os riscos de prioridade alta são revistos semanalmente pelo gerente e reportados ao patrocinador se ameaçarem baseline ou critérios de qualidade.

### 8.3 Diagrama de Ishikawa — causa-raiz do atraso em catálogo e filtros (R02)

```text
Pessoas ───── requisitos sem refinamento; indisponibilidade do curador ──┐
Método ────── critérios de aceite tardios; WIP excessivo ───────────────┤
Tecnologia ── modelo de dados inadequado; consulta sem índice ──────────┼── Efeito:
Dados ─────── taxonomia incompleta; questões com campos ausentes ───────┤   atraso no catálogo
Ambiente ───── credenciais ou banco indisponíveis ───────────────────────┤   e nos filtros (R02)
Medição ────── progresso reportado sem teste de aceite ──────────────────┘
```

A análise indica prevenção prioritária: validar a taxonomia e os critérios de aceite antes da implementação, manter o trabalho em progresso limitado, disponibilizar massa de dados de teste e medir progresso somente quando a funcionalidade for demonstrada. Se o gatilho ocorrer, o gerente convoca análise de causa, atualiza o cronograma, decide se é possível reordenar trabalho não crítico e submete qualquer alteração de baseline ao patrocinador.

## 9. Rotina de controle

* Atualizar o GitHub Projects diariamente durante a execução, com status, responsável, prioridade, dependências e evidências de aceite.
* Comparar progresso físico e custos com a baseline semanalmente; calcular EVM a cada marco ou, no mínimo, quinzenalmente.
* Revisar riscos altos semanalmente e todos os riscos no comitê quinzenal.
* Registrar defeitos, decisões, lições aprendidas e solicitações de mudança em issues rastreáveis.
* Apresentar ao patrocinador uma recomendação explícita sempre que CPI ou SPI permanecer abaixo de 0,90 em duas medições consecutivas.
