using Teste.Models;

namespace Teste.Repository
{
    public class ComentarioRepository : IComentarioRepository
    {
        

        private Context _context;

        public ComentarioRepository(Context context)
        {
            _context = context;
        }

        public object Salvar(string Nome, string Comentario)
        {
                var salva = new Comentario(){
                    nome = Nome,
                    comenta = Comentario
                };

                _context.comentario.Add(salva);
                _context.SaveChanges();

                return "foi ";
          
        }
    }
}