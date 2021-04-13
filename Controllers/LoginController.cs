using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Teste.Models;
using Teste.Repository;

namespace Teste.Controllers
{
    public class LoginController : Controller
    {
        private readonly ILoginRepository _loginRepository;

        public LoginController(ILoginRepository loginRepository){
            _loginRepository = loginRepository;
        }

        [HttpPost]
        public IActionResult Login(string nome, string senha){
            return Ok(_loginRepository.LoginValid(nome, senha));
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}