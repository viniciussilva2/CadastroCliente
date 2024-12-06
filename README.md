# Cadastro de Clientes API

Uma API REST desenvolvida em .NET 8 que utiliza o padrão de repositório (Repository Pattern) para gerenciar dados e operações relacionadas ao cadastro de clientes.

## 🛠 Estrutura do Projeto

O projeto segue uma arquitetura organizada em camadas, com as seguintes pastas principais:

- **Controllers**: Contém os controladores que gerenciam as requisições e respostas HTTP.
- **Data**: Gerencia o contexto do banco de dados e a configuração inicial.
- **Migrations**: Contém os arquivos de migração gerados pelo Entity Framework.
- **Models**: Define as classes de domínio usadas na aplicação.
- **Repository**: Implementa o padrão de repositório para acesso aos dados.
- **Services**: Contém a lógica de negócio da aplicação.
- **Properties**: Arquivos de configuração específicos do projeto.

## 🌟 Funcionalidades

- Criação, leitura, atualização e exclusão de clientes (CRUD).
- Implementação do padrão Repository Pattern para acesso aos dados.
- Configuração para múltiplos ambientes com arquivos `appsettings.json`.
- API REST com endpoints documentados para facilitar o uso.

## 🚀 Tecnologias Utilizadas

- **.NET 8**
- **Entity Framework Core**
- **SQL Server**
- **REST API**

## ⚙️ Configuração e Uso

### Pré-requisitos

- [Instale o .NET SDK](https://dotnet.microsoft.com/download) (versão 8 ou superior).
- Um banco de dados SQL Server configurado.

- {
  "ConnectionStrings": {
    "DefaultConnection": "Server=SEU_SERVIDOR;Database=CadastroClienteDB;Trusted_Connection=True;"
  }
}
📂 Estrutura dos Endpoints
GET /api/clientes: Lista todos os clientes.
GET /api/clientes/{id}: Obtém um cliente pelo ID.
POST /api/clientes: Cria um novo cliente.
PUT /api/clientes/{id}: Atualiza um cliente existente.
DELETE /api/clientes/{id}: Exclui um cliente.
📖 Documentação
A API conta com documentação automática gerada (se configurada com Swagger). Para acessá-la, inicie a aplicação e navegue até https://localhost:5001/swagger.

