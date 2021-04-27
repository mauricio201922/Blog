using Teste.Models;

namespace Teste.Repository
{
    public class ContatoRepository : IContatoRepository
    {
        private Context _context;

        public ContatoRepository(Context context){
            _context = context;
        }
        public void EnviarContatoRepo(string _nome, string _email, string _telefone, string _mensagem){
            
            var data = new Contato(){
                nome = _nome,
                email = _email,
                telelefone = _telefone,
                msg = _mensagem
            };

            _context.contato.Add(data);
            _context.SaveChanges();
            
        }
    }
}