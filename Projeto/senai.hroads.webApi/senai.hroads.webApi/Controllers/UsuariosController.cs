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
    public class UsuarioController : ControllerBase
    {
        private IUsuarioRepository _UsuarioRepository { get; set; }
        public UsuarioController()
        {
            _UsuarioRepository = new UsuarioRepository();
        }

        [Authorize(Roles = "1, 2")]
        [HttpGet]
        public IActionResult Listar()
        {
            return Ok(_UsuarioRepository.Listar());
        }

        [Authorize(Roles = "1, 2")]
        [HttpGet("{idUsuario}")]
        public IActionResult BuscarPorId(int idUsuario)
        {
            return Ok(_UsuarioRepository.BuscarPorId(idUsuario));
        }

        [Authorize(Roles = "1")]
        [HttpPost]
        public IActionResult Cadastrar(Usuario novoUsuario)
        {
            _UsuarioRepository.Cadastrar(novoUsuario);

            return StatusCode(201);
        }

        [Authorize(Roles = "1, 2")]
        [HttpPut("{idUsuario}")]
        public IActionResult Atualizar(int idUsuario, Usuario UsuarioAtualizado)
        {
            _UsuarioRepository.Atualizar(idUsuario, UsuarioAtualizado);

            return StatusCode(204);
        }

        [Authorize(Roles = "1, 2")]
        [HttpDelete("{idUsuario}")]
        public IActionResult Deletar(int idUsuario)
        {
            _UsuarioRepository.Deletar(idUsuario);

            return StatusCode(204);
        }
    }
}