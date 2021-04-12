using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Diagnostics;
using Teste.Models;

namespace Teste.Controllers
{
    [Route("Usuarios")]
    public class UsuariosController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public UsuariosController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [Route("DadosUsuarios")]
        public IActionResult Usuarios(){
            return View();
        }

        public IActionResult SaveData(dynamic nome, dynamic comentario){

            Context db = new Context();

            Comentario cm = new Comentario();
            cm.nome = nome;
            cm.comenta = comentario;

            return View();
        }
    }
}