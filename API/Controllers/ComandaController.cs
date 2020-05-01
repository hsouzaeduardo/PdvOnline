using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dominio.Contratos;
using Dominio.Entity;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ComandaController : ControllerBase
    {
        private readonly IComanda _comanda;
        private readonly INota _nota;
        private readonly IRepositorio<Item> _item;


        public ComandaController(IComanda comanda, INota nota, IRepositorio<Item> item)
        {
            _comanda = comanda;
            _nota = nota;
            _item = item;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_comanda.Get());
        }
    }
}