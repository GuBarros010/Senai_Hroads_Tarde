using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using senai.hroads.webApi.Domains;
using senai.hroads.webApi.Interfaces;
using senai.hroads.webApi.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai.hroads.webApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class TipoHabilidadeController : ControllerBase
    {
        private ITipoHabilidadeRepository _TipoHabilidadeRepository { get; set; }
        public TipoHabilidadeController()
        {
            _TipoHabilidadeRepository = new TipoHabilidadeRepository();
        }

        [Authorize(Roles = "1, 2")]
        [HttpGet]
        public IActionResult Listar()
        {
            return Ok(_TipoHabilidadeRepository.Listar());
        }

        [Authorize(Roles = "1, 2")]
        [HttpGet("{idTipoHabilidade}")]
        public IActionResult BuscarPorId(int idTipoHabilidade)
        {
            return Ok(_TipoHabilidadeRepository.BuscarPorId(idTipoHabilidade));
        }

        [Authorize(Roles = "1")]
        [HttpPost]
        public IActionResult Cadastrar(TipoHabilidade novoTipoHabilidade)
        {
            _TipoHabilidadeRepository.Cadastrar(novoTipoHabilidade);

            return StatusCode(201);
        }

        [Authorize(Roles = "1, 2")]
        [HttpPut("{idTipoHabilidade}")]
        public IActionResult Atualizar(int idTipoHabilidade, TipoHabilidade TipoHabilidadeAtualizado)
        {
            _TipoHabilidadeRepository.Atualizar(idTipoHabilidade, TipoHabilidadeAtualizado);

            return StatusCode(204);
        }

        [Authorize(Roles = "1, 2")]
        [HttpDelete("{idTipoHabilidade}")]
        public IActionResult Deletar(int idTipoHabilidade)
        {
            _TipoHabilidadeRepository.Deletar(idTipoHabilidade);

            return StatusCode(204);
        }
    }
}
