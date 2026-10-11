<h1 align="center">🗂️ Gestor de Clientes API</h1>

<p align="center">
  API REST para gestão de clientes com integração a banco de dados.
</p>

<p align="center">
  <img src="https://img.shields.io/badge/C%23-512BD4?style=for-the-badge&logo=dotnet&logoColor=white" />
  <img src="https://img.shields.io/badge/ASP.NET%20Core-512BD4?style=for-the-badge&logo=dotnet&logoColor=white" />
  <img src="https://img.shields.io/badge/EF%20Core-512BD4?style=for-the-badge&logo=dotnet&logoColor=white" />
  <img src="https://img.shields.io/badge/SQLite-003B57?style=for-the-badge&logo=sqlite&logoColor=white" />
</p>

---

### ✨ Funcionalidades

- ✅ Cadastro, listagem, busca e inativação de clientes
- ✅ Validação de nome, e-mail e CPF dentro do domínio
- ✅ Inativação em vez de exclusão, preservando o histórico
- ✅ Arquitetura orientada a objetos com injeção de dependência

### 🔗 Endpoints

| Método | Rota | O que faz |
|---|---|---|
| GET | `/clientes` | Lista os clientes ativos |
| GET | `/clientes/{id}` | Busca um cliente pelo id |
| POST | `/clientes` | Cadastra um cliente |
| DELETE | `/clientes/{id}` | Inativa um cliente |

### ▶️ Como rodar

1. Clone o repositório
2. Crie o banco: `dotnet ef database update`
3. Rode a API: `dotnet run`
4. Teste os endpoints pelo arquivo `GestorClientesApi.http`

---

<p align="center">
  Desenvolvido por <a href="https://github.com/Raissa-silvia">Raissa Silva</a> ·
  <a href="https://www.linkedin.com/in/raissa-silvia">LinkedIn</a>
</p>