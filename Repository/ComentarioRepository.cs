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

        // Objeto que salva no banco os dados
        public object Salvar(string Nome, string Comentario)
        {
            // variável 'salva' istância e já recebe a lista de dados que o Banco de Dados tem para pegar
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