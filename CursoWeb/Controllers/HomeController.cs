using System.Diagnostics;
using CursoWeb.Interfaces;
using CursoWeb.Models;
using Microsoft.AspNetCore.Mvc;

namespace CursoWeb.Controllers
{
    public class HomeController : Controller
    {
        private readonly ISessao _sessao;

        public HomeController(ISessao sessao)
        {
            _sessao = sessao;
        }
        public IActionResult MetodosPage(string valor1, string valor2)
        {
            ViewData["valor1"] = valor1;
            ViewData["valor2"] = valor2;
            ViewData["result"] = Multiplicar(Convert.ToDouble(valor1), Convert.ToDouble(valor2));
            return View();
        }
        private double Multiplicar(double v1, double v2)
        {
            return v1 * v2;
        }
        public IActionResult Index(UserModel user)
        {
            if (_sessao.BuscarSessaoDoUsuario() != null)
                return View();
            else
                return RedirectToAction("Login", "User");
        }
        public IActionResult Sobre()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult cards()
        {
            return View();
        }
    }
}
