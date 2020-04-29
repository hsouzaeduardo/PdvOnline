using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using UX.Models;

namespace UX.Controllers
{
    [Route("comanda")]
    public class ComandaController : Controller
    {
        /// <summary>
        /// BDZ10000
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        [Route("abrir/{numeroComanda:regex(^[[A-Z]]{{3}}\\d{{4}}$)}")]
        [Route("abrir/{numeroComanda:regex(^[[A-Z]]{{3}}\\d{{4}}$)}/{garcon:minlength(6):maxlength(10)}")]
        public IActionResult Abrir(string numeroComanda, string garcon)
        {
            return Ok();
        }

        [HttpPut]
        [Route("fechar/{numeroComanda:regex(^[[A-Z]]{{3}}\\d{{4}}$)}/{cpf:long}")]
        public IActionResult Fechar(string numeroComanda, long cpf)
        {
            return Ok();
        }

        [HttpPost]
        [Route("/item/adicionar")]
        public IActionResult IncluirItem([FromBody] ItemNovoViewModel item)
        {
            return PartialView();
        }

        [HttpDelete]
        [Route("/item/remover/{numeroComanda}/{itemId:Guid}")]
        public IActionResult RemoverItem(string numeroComanda, Guid itemId)
        {
            return PartialView();
        }

        [HttpGet]
        [Route("")]
        public IActionResult ListarTodas()
        {

            var lista = new List<Comanda>();
            lista.Add(new Comanda()
            {
                Abertura = DateTime.Now,
                Status = StatusComanda.Aberta,
                Numero = "BDZ1000",
                Garcon = "JOSSEF"
            });

            return View(lista);
        }
    }
}