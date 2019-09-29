using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyClinic.Application.Interfaces;
using MyClinic.Domain.Entities;

namespace MyClinic.WebApi.Controllers
{
    public class UsuarioController : Controller
    {
        private readonly IUsuarioAppService _usuarioAppService;

        public UsuarioController(IUsuarioAppService usuarioAppService)
        {
            this._usuarioAppService = usuarioAppService;
        }
        public IActionResult Teste()
        {
            var usuario = new Usuario();
            usuario.ConfigurarPermissao(Domain.Enums.EPapel.Administrador, "");

            this._usuarioAppService.Add(usuario);

            return Ok("ok");
        }
    }
}