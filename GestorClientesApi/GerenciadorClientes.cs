using System.Collections.Generic;
using System.Linq;

namespace GestorClientesApi
{
    public class GerenciadorClientes
    {
        private readonly AppDbContext _context;

        public GerenciadorClientes(AppDbContext context)
        {
            _context = context;
        }

        public Cliente Adicionar(string nome, string email, string cpf)
        {
            var cliente = new Cliente(nome, email, cpf);
            _context.Clientes.Add(cliente);
            _context.SaveChanges();
            return cliente;
        }

        public List<Cliente> Listar()
        {
            return _context.Clientes.Where(c => c.Ativo).ToList();
        }

        public Cliente? Buscar(int id)
        {
            return _context.Clientes.Find(id);
        }

        public bool Remover(int id)
        {
            var cliente = _context.Clientes.Find(id);
            if (cliente == null) return false;

            cliente.Inativar();
            _context.SaveChanges();
            return true;
        }
    }
}
