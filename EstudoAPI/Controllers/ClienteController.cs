using EstudoAPI.Models;
using EstudoAPI.Services.Interfaces;
using System.Collections.Generic;
using System.Web.Http;

namespace EstudoAPI.Controllers
{
    public class ClienteController : ApiController
    {
        private readonly IClienteService clienteService;

        public ClienteController(IClienteService clienteService)
        {
            this.clienteService = clienteService;
        }

        [HttpGet]
        [Route("cliente/teste")]
        public string Testar()
        {
            return "Teste roda";
        }

        [HttpGet]
        public IEnumerable<ClienteModel> BuscarToos()
        {
            return clienteService.getClientes();
        }

        [HttpGet]
        public IHttpActionResult BuscarPorId([FromUri]int id)
        {
            return Ok(clienteService.getCliente(id));
        }

        [HttpPost]
        public void NovoCliente([FromBody]ClienteModel novoCliente)
        {
            clienteService.novoCliente(novoCliente);
        }

        [HttpPut]
        public void EditarCliente([FromBody]ClienteModel cliente)
        {
            clienteService.editarCliente(cliente);
        }

        [HttpDelete]
        public void DeletarCliente([FromUri]int id)
        {
            clienteService.deletarCliente(id);
        }
    }
}
