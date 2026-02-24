Sistema de catálogo de Categorias e Produtos desenvolvido com foco em boas práticas de arquitetura e separação de responsabilidades, utilizando Clean Architecture, CQRS e autenticação JWT.

O projeto foi estruturado visando alta coesão, baixo acoplamento e facilidade de manutenção, permitindo evolução do domínio sem impactar diretamente a camada de apresentação ou infraestrutura.

🚀 Tecnologias e Conceitos Utilizados

- .NET 10

- ASP.NET Core MVC

- Razor Pages

- Clean Architecture

- CQRS (Command Query Responsibility Segregation)

- Injeção de Dependência nativa do .NET

- AutoMapper

- Entity Framework Core

- Autenticação com JWT

- SQL Server

🏗 Arquitetura

O projeto segue os princípios da Clean Architecture, separando responsabilidades em camadas bem definidas:

🔹 Domain

Entidades

Regras de negócio

Validações

Interfaces de repositório

🔹 Application

Casos de uso

Commands e Queries (CQRS)

DTOs

Handlers

Mapeamentos com AutoMapper

🔹 Infrastructure

Implementação de repositórios

Contexto do Entity Framework

Configurações de persistência

🔹 WebUI

Controllers (MVC)

Razor Pages

Configuração de autenticação JWT

Configuração de Injeção de Dependência

Essa separação permite trocar tecnologias de infraestrutura (ex: ORM) sem impactar o domínio da aplicação.

🔄 CQRS

O projeto utiliza o padrão CQRS, separando:

Commands → operações de escrita (Create, Update, Delete)

Queries → operações de leitura

Isso traz:

Melhor organização

Maior clareza de responsabilidade

Facilidade para escalar leitura/escrita separadamente

🔐 Autenticação

A autenticação é feita via JWT (JSON Web Token).

Geração de token após login

Validação via middleware

Proteção de rotas com [Authorize]
