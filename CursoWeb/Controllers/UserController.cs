using CursoWeb.Interfaces;
using CursoWeb.Models;
using Microsoft.AspNetCore.Mvc;

namespace CursoWeb.Controllers
{
    public class UserController : Controller
    {
        private readonly ISessao _sessao;
        public UserController(ISessao sessao)
        {
            _sessao = sessao;
        }
        public IActionResult Index()
        {
            if (_sessao.BuscarSessaoDoUsuario() != null) return RedirectToAction("Index", "Home");
            return View();
        }
        public IActionResult Novo()
        {
            return View();
        }
        public IActionResult Login(UserModel user)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    user.Login = user.Login;
                    user.Password = user.Password;

                    _sessao.CriarSessaoDoUsuario(user);
                    return RedirectToAction("Index", "Home");
                }
                return View();
            }
            catch (Exception)
            {

            }
            return View(user);
        }
        public IActionResult Editar()
        {
            return View();
        }
        public IActionResult Logout()
        {
            _sessao.RemoverSessaoDoUsuario();
            return RedirectToAction("Login");
        }
    }
}
