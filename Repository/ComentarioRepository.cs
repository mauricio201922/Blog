using System.Linq;
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

            return salva;
          
        }

        public object RetornaComentarios(){

            var dados = _context.comentario.ToList();


            return dados;
        }

        public bool LoginValid(string nome, string senha){
            var dados = _context.login.ToList();

            for(var i = 0; i < dados.Count; i++){
                if(dados[i].nome == nome && dados[i].senha == senha) return true;
            }

            return false;
        }

        public void DeletarComentario(int id){
            
            Comentario com = _context.comentario.Find(id);

            _context.comentario.Remove(com);
            _context.SaveChanges();
        }

        
    }
}