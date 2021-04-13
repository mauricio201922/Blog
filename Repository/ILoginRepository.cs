namespace Teste.Repository
{
    public interface ILoginRepository
    {
        object LoginValid(string nome, string senha);
    }
}