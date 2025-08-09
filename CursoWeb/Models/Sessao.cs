using CursoWeb.Interfaces;
using Newtonsoft.Json;

namespace CursoWeb.Models
{
    public class Sessao : ISessao
    {
        private readonly IHttpContextAccessor _httpContext;
        public Sessao(IHttpContextAccessor httpContext)
        {
            _httpContext = httpContext;
        }
        public UserModel BuscarSessaoDoUsuario()
        {
            string sessaoUsuario = _httpContext.HttpContext.Session.GetString("SessaoUsuarioLogado2");

            if (string.IsNullOrEmpty(sessaoUsuario)) return null;

            return JsonConvert.DeserializeObject<UserModel>(sessaoUsuario);
        }

        public void CriarSessaoDoUsuario(UserModel model)
        {
            //criando a sessao do usuario
            string valor = JsonConvert.SerializeObject(model);

            _httpContext.HttpContext.Session.SetString("SessaoUsuarioLogado2", valor);
        }

        public void RemoverSessaoDoUsuario()
        {
            //Remover a sessao do usuario
            _httpContext.HttpContext.Session.Remove("SessaoUsuarioLogado2");
        }
    }
}
