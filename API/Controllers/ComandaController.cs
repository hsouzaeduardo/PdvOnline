using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dominio.Contratos;
using Dominio.Entity;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/comanda")]
    [ApiController]
    [EnableCors("cors")]
    public class ComandaController : ControllerBase
    {
        private readonly IComanda _comanda;
        private readonly INota _nota;
        private readonly IRepositorio<Item> _item;
        private readonly IRepositorio<Conta> _conta;


        public ComandaController(IComanda comanda, INota nota, IRepositorio<Item> item, IRepositorio<Conta> conta)
        {
            _comanda = comanda;
            _nota = nota;
            _item = item;
            _conta = conta;
        }

        [HttpGet]
        [Route("/api/comanda")]
        public IActionResult BuscarTodos()
        {
            return Ok(_comanda.Get());
        }
        
        [HttpGet]
        [Route("/api/comanda/buscar/{numeroComanda:regex(^[[A-Z]]{{3}}\\d{{4}}$)}/{id:range(10,20)}")]
        public IActionResult BuscarNumero(string numeroComanda, int id)
        {
            var comandaResult = _comanda.GetComandaNumero(numeroComanda);
            if (comandaResult != null)
            {
                return Ok(comandaResult);
            }
            
            var erro = new
            {
                Erro= "Comanda não encontrada"
            };

            return NotFound(erro);
        }


        [HttpGet("/api/item")]
        public async Task<IActionResult> BuscarTodosItem() => Ok(await _item.GetAynsc());


        [HttpGet("/api/item/buscar/{id:guid}")]
        public async Task<IActionResult> BuscarTodosItem(Guid id)
        {
            return Ok(await _item.GetAynsc(id));
        }



    }
}