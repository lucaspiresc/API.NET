using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Estudo_WebAPI.Models
{
    public class ClienteModel
    {
        public Guid IdCliente { get; set; }

        public string Nome { get; set; }

        public string Email { get; set; }
    }
}