using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Futebol.Dados.Api.Models;
using Futebol.Dados.Api.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Futebol.Dados.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JogosController : ControllerBase
    {
        private readonly JogoService _jogoService;

        public JogosController(JogoService jogoService)
        {
            _jogoService = jogoService;
        }

        [HttpGet]
        public ActionResult<List<Jogo>> Get()
        {
            var jogo = _jogoService.Jogos(2012, 1);

            if (jogo == null)
                return NotFound();

            return jogo;
        }
    }
}