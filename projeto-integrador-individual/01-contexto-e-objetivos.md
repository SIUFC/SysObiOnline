# 01 - Contexto e objetivos

## Contexto

O projeto SysObiOnline foi concebido como uma solução back-end para facilitar o acesso de estudantes aos exercícios e às questões da Olimpíada Brasileira de Informática (OBI). A ideia central é centralizar o conteúdo, simplificar a consulta por filtros e permitir que o sistema acompanhe o desempenho dos usuários ao responder questões.

A solução já apresenta uma base de backend profissional, com autenticação por tokens JWT, API REST, acesso ao banco de dados via Entity Framework Core e organização em camadas de controller, service e repository.

## Problema identificado

Estudantes e usuários do sistema precisam:

- acessar um conjunto organizado de questões da OBI;
- filtrar por nível, fase e ano;
- autenticar-se com segurança;
- receber feedback sobre respostas corretas ou incorretas;
- acompanhar desempenho por meio de relatórios.

Sem essa estrutura, o conteúdo fica disperso, sem controle de acesso e sem rastreio de participações.

## Objetivo geral

Desenvolver e documentar uma solução que permita o cadastro, autenticação, consulta e avaliação de questões relacionadas à OBI, oferecendo uma API robusta e integrada a banco de dados.

## Objetivos específicos

- implementar autenticação de usuários com JWT;
- permitir cadastro e atualização de usuários;
- criar, consultar e filtrar questões;
- registrar respostas em um histórico de quiz;
- calcular indicadores de acerto e erro;
- disponibilizar a API com documentação via Swagger;
- manter a solução em um ambiente organizado para uso em integração com frontend.

## Público-alvo

- alunos interessados em praticar questões da OBI;
- professores ou administradores que gerenciam o conteúdo;
- usuários do sistema com diferentes papéis, incluindo administração de questões.

## Benefícios esperados

- centralização do conteúdo de questões;
- melhor organização do material por nível, fase e ano;
- melhoria na experiência do usuário;
- maior segurança com autenticação e autorização;
- geração de acompanhamento de desempenho.

## Conclusão

A proposta do projeto combina tecnologia, organização e gestão de conhecimento para criar uma plataforma funcional e escalável de apoio ao estudo e à prática de questões da OBI.
