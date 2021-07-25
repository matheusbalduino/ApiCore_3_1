using controleCobranca.Data;
using controleCobranca.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
        
        [HttpPost]
        public async Task<IActionResult> Create(Cliente c)
        {

            try
            {
                _context.Add(c);

                if(await saveChangesAsync())
                {
                    return Created($"cliente/{c.indice}", c);

                }
            }
            catch(System.Exception)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Sua Requisição Falhou");
            }

            return BadRequest();
           
        }

        public async Task<bool> saveChangesAsync()
        {
            return (await _context.SaveChangesAsync()) > 0;
        }

    }
}
