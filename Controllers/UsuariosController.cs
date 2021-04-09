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
    }
}