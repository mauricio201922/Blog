namespace Teste.Repository
{
    public interface IComentarioRepository
    {
        object Salvar(string Nome, string Comentario);
        object RetornaComentarios();

        bool LoginValid(string nome, string senha);
    }
}