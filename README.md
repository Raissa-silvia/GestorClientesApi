<h1 align="center">🗂️ Gestor de Clientes API</h1>



<p align="center">

&#x20; API REST para gestão de clientes com integração a banco de dados.

</p>



<p align="center">

&#x20; <img src="https://img.shields.io/badge/C%23-512BD4?style=for-the-badge\&logo=dotnet\&logoColor=white" />

&#x20; <img src="https://img.shields.io/badge/ASP.NET%20Core-512BD4?style=for-the-badge\&logo=dotnet\&logoColor=white" />

&#x20; <img src="https://img.shields.io/badge/EF%20Core-512BD4?style=for-the-badge\&logo=dotnet\&logoColor=white" />

&#x20; <img src="https://img.shields.io/badge/SQLite-003B57?style=for-the-badge\&logo=sqlite\&logoColor=white" />

</p>



\---



\### ✨ Funcionalidades



\- ✅ Cadastro, listagem, busca e inativação de clientes

\- ✅ Validação de nome, e-mail e CPF dentro do domínio

\- ✅ Inativação em vez de exclusão, preservando o histórico

\- ✅ Arquitetura orientada a objetos com injeção de dependência



\### 🔗 Endpoints



| Método | Rota | O que faz |

|---|---|---|

| GET | `/clientes` | Lista os clientes ativos |

| GET | `/clientes/{id}` | Busca um cliente pelo id |

| POST | `/clientes` | Cadastra um cliente |

| DELETE | `/clientes/{id}` | Inativa um cliente |



\### 🗂️ Estrutura do projeto



| Pasta / arquivo | Responsabilidade |

|---|---|

| `Models/Cliente.cs` | Entidade Cliente, com as regras de validação e o método `Inativar()` |

| `Services/GerenciadorClientes.cs` | Regras de negócio: adicionar, listar, buscar e inativar |

| `Data/AppDbContext.cs` | Conexão com o banco de dados (Entity Framework Core) |

| `Dtos/NovoClienteDto.cs` | Formato dos dados recebidos no cadastro |

| `Migrations/` | Histórico da estrutura do banco de dados |

| `Program.cs` | Configuração da API e definição dos endpoints |

| `GestorClientesApi.http` | Requisições prontas para testar a API |



\### ▶️ Como rodar



1\. Clone o repositório

2\. Entre na pasta do projeto: `cd GestorClientesApi`

3\. Crie o banco de dados: `dotnet ef database update`

4\. Rode a API: `dotnet run`

5\. Teste os endpoints pelo arquivo `GestorClientesApi.http`



\---



<p align="center">

&#x20; Desenvolvido por <a href="https://github.com/Raissa-silvia">Raissa Silva</a> ·

&#x20; <a href="https://www.linkedin.com/in/raissa-silvia">LinkedIn</a>

</p>

