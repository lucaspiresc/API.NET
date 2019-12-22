using EstudoAPI.Models;
using EstudoAPI.Services.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace EstudoAPI.Services
{
    public class ClienteService : IClienteService
    {
        private readonly List<ClienteModel> clientes;

        public ClienteService()
        {
            clientes = new List<ClienteModel>();
        }

        public ClienteModel getCliente(int id)
        {
            return clientes.FirstOrDefault(c => c.IdCliente == id);
        }

        public List<ClienteModel> getClientes()
        {
            return clientes;
        }

        public ClienteModel novoCliente(ClienteModel cliente)
        {
            clientes.Add(cliente);
            return cliente;
        }

        public void editarCliente(ClienteModel cliente)
        {
            deletarCliente(cliente.IdCliente);
            clientes.Add(cliente);
        }

        public void deletarCliente(int id)
        {
            var cliente = clientes.FirstOrDefault(c => c.IdCliente == id);
            if(cliente != null)
            {
                clientes.Remove(cliente);
            }
        }
    }
}