namespace Teste.Repository
{
    public interface IContatoRepository
    {
         object EnviarContatoRepo(string _nome, string _email, string _telefone, string _mensagem);
    }
}