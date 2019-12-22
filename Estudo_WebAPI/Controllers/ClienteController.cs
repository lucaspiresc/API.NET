using Estudo_WebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Estudo_WebAPI.Controllers
{
    public class ClienteController : ApiController
    {
        public List<ClienteModel> clientes = new List<ClienteModel>();

        [HttpPost]
        public IHttpActionResult Post([FromBody]ClienteModel novoCliente)
        {
            clientes.Add(novoCliente);

            return Ok(novoCliente);
        }

        [HttpGet]
        public IHttpActionResult Get()
        {
            return Ok(clientes);
        }

        [HttpDelete]
        public IHttpActionResult removerCliente([FromUri]Guid idCliente)
        {
            var clienteRemover = clientes.FirstOrDefault(c => c.IdCliente == idCliente);
            clientes.Remove(clienteRemover);

            return Ok();
        }
    }
}
