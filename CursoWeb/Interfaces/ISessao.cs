using CursoWeb.Models;

namespace CursoWeb.Interfaces
{
    public interface ISessao
    {
        void CriarSessaoDoUsuario(UserModel user);//Log-in
        void RemoverSessaoDoUsuario();//Logout
        UserModel BuscarSessaoDoUsuario(); //GetSession
    }
}
