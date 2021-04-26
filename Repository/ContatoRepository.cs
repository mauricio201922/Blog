namespace Teste.Repository
{
    public class ContatoRepository : IContatoRepository
    {
        public object EnviarContatoRepo(string _nome, string _email, string _telefone, string _mensagem){
            return true;
        }
    }
}