using System.Linq;
using Teste.Models;

namespace Teste.Repository
{
    public class LoginRepository
    {

        private Context _context;

        public LoginRepository(Context context)
        {
            _context = context;
        }
        
        public object LoginValid(string nome, string senha){
            var dados = _context.login.ToList();

            if(dados[0].ToString() == nome && dados[1].ToString() == senha) return true;

            return false;
        }
    }
}