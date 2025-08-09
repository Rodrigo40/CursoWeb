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
            if (_sessao.BuscarSessaoDoUsuario() != null) 
                return RedirectToAction("Index", "Home");
            return View();
        }
        public IActionResult Novo()
        {
            return View();
        }
        public IActionResult Login()
        {
            bool logado = _sessao.BuscarSessaoDoUsuario() != null ? true : false;
            ViewBag.log = logado;
            return View();
        }
        public IActionResult LoginLogar(UserModel user)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _sessao.CriarSessaoDoUsuario(user);
                    return RedirectToAction("Index", "Home");
                }
                return View("Login",user);
            }
            catch (Exception)
            {

            }
            return View("Login");
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
