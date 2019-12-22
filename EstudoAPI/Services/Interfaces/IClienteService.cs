using EstudoAPI.Models;
using System.Collections.Generic;

namespace EstudoAPI.Services.Interfaces
{
    public interface IClienteService
    {
        ClienteModel getCliente(int id);
        List<ClienteModel> getClientes();
        ClienteModel novoCliente(ClienteModel cliente);
        void editarCliente(ClienteModel cliente);
        void deletarCliente(int id);
    }
}
