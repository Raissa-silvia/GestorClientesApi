using System;

namespace GestorClientesApi
{
    public class Cliente
    {
        private Cliente() { } // só o Entity Framework usa

        public int Id { get; private set; }
        public string Nome { get; private set; } = string.Empty;
        public string Email { get; private set; } = string.Empty;
        public string Cpf { get; private set; } = string.Empty;
        public bool Ativo { get; private set; }

        public Cliente(string nome, string email, string cpf)
        {
            if (string.IsNullOrWhiteSpace(nome))
                throw new ArgumentException("O nome não pode ser vazio.");

            if (string.IsNullOrWhiteSpace(email) || !email.Contains("@"))
                throw new ArgumentException("E-mail inválido.");

            if (string.IsNullOrWhiteSpace(cpf) || cpf.Length != 11)
                throw new ArgumentException("CPF inválido. Deve conter 11 dígitos.");

            this.Nome = nome;
            this.Email = email;
            this.Cpf = cpf;
            this.Ativo = true;
        }

        public void Inativar()
        {
            Ativo = false;
        }
    }
}