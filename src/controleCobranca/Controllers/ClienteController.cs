using controleCobranca.Data;
using controleCobranca.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace controleCobranca.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClienteController : ControllerBase
    {
        private readonly DataContext _context;

        public ClienteController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Cliente> Get()
        {
            return _context.Clientes;
        }
        
        [HttpGet("{indice}")]
        public Cliente Get(int Indice)
        {
            return _context.Clientes.FirstOrDefault(cliente => cliente.indice == Indice);
        }

    }
}
