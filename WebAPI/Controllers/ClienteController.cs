using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    public class ClienteController : ApiController
    {
        new List<ClienteModel> clientes = new List<ClienteModel>();

        public IHttpActionResult Get()
        {
            var Cliente = new ClienteModel()
            {
                IdCliente = 1,
                Nome = "Lucas",
                Email = "lucascicutti1995@gmail.com"
            };
            clientes.Add(Cliente);

            return Ok(clientes);
        }

        public ClienteModel Get(int id)
        {
            return clientes.First(c => c.IdCliente == id);
        }

        public void Post([FromBody]ClienteModel cliente)
        {
            clientes.Add(cliente);
        }

        public void Put(int id, [FromBody]ClienteModel cliente)
        {
        }

        public void Delete(int id)
        {
            var clienteDeletar = clientes.FirstOrDefault(c => c.IdCliente == id);
            clientes.Remove(clienteDeletar);
        }
    }
}
