using Microsoft.AspNetCore.Mvc;
using Teste.Repository;

namespace Teste.Controllers
{
    public class ContatoController : Controller
    {
        private readonly IContatoRepository _contatoRepository;

        public ContatoController(IContatoRepository contatoRepository)
        {
            _contatoRepository = contatoRepository;
        }

        [HttpPost]
        public IActionResult EnviarContato(string nome, string email, string telefone, string mensagem){
            _contatoRepository.EnviarContatoRepo(nome, email, telefone, mensagem);
            return Ok();
        }
    }
}