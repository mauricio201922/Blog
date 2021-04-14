using System.Linq;
using Teste.Models;

namespace Teste.Repository
{
    public class CadastroRepository : ICadastroRepository
    {
        private Context _context;

        public CadastroRepository(Context context){
            _context = context;
        }
        public bool Salvar(string _nome, string _senha){
            
            var salvar = new Login(){
                nome = _nome,
                senha = _senha
            };

            var dados = _context.login.ToList();

            for(var i = 0; i < dados.Count; i++){
                if(salvar.nome == dados[i].nome) return false;
            }

            _context.login.Add(salvar);
            _context.SaveChanges();

            return true;
            
        }
    }
}