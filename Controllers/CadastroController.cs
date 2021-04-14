using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Teste.Models;
using Teste.Repository;

namespace Teste.Controllers
{
    public class CadastroController : Controller
    {
        private readonly ICadastroRepository _cadastroRepository;

        public CadastroController(ICadastroRepository cadastroRepository){
            _cadastroRepository = cadastroRepository;
        }

        [Route("cadastro")]
        public IActionResult TelaCadastro(){
            return View();
        }

        [HttpPost]
        public IActionResult SalvaCadastro(string nome, string senha){
            return Ok(_cadastroRepository.Salvar(nome, senha));
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


    }
}