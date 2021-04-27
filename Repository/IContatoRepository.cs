namespace Teste.Repository
{
    public interface IContatoRepository
    {
         void EnviarContatoRepo(string _nome, string _email, string _telefone, string _mensagem);
    }
}