using CursoWeb.Models;

namespace CursoWeb.Interfaces
{
    public interface IPessoa
    {
        List<Pessoa> GetPessoa();
        string Adicionar(Pessoa pessoa);
    }
}
