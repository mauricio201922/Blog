using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Teste.Models;
using Teste.Repository;

namespace Teste.Controllers
{
    public class HomeController : Controller
    {
        private readonly IComentarioRepository _comentarioRepository;

        public HomeController(IComentarioRepository comentarioRepository)
        {
            _comentarioRepository = comentarioRepository;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [Route("comentario")]
        public IActionResult Comentario(){
            return View();
        }

        [HttpPost]
        public IActionResult Salvar(string nome, string comentario){
           
            return Ok(_comentarioRepository.Salvar(nome, comentario)); 
            
        }

        [HttpGet]
        public IActionResult RetornaComentarios(){

            return Ok(_comentarioRepository.RetornaComentarios());

        }

        /* Retorna um valor do method LoginValid caso for 'OK = 200' */
        [HttpPost]
        public IActionResult Logar(string nome, string senha){
            return Ok(_comentarioRepository.LoginValid(nome, senha));
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
