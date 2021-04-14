namespace Teste.Repository
{
    public interface ICadastroRepository
    {
        bool Salvar(string _nome, string _senha);
    }
}