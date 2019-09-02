using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Futebol.Dados.Api.DTOs;
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
        public ActionResult<List<JogoDTO>> Get(int ano, int rodada)
        {
            var jogo = _jogoService.Jogos(ano, rodada);

            if (jogo == null)
                return NotFound();

            return jogo;
        }
    }
}