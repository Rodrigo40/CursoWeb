using DemoSessoesMVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DemoSessoesMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            // Tenta obter o nome do usuário da sessão.
            string nomeUsuario = HttpContext.Session.GetString("NomeUsuario");

            if (string.IsNullOrEmpty(nomeUsuario))
            {
                // Se o nome não existir, armazena um valor na sessão.
                HttpContext.Session.SetString("NomeUsuario", "Usuário de Teste");
                ViewBag.Mensagem = "Olá, bem-vindo pela primeira vez!";
            }
            else
            {
                // Se o nome existir, exibe uma mensagem de boas-vindas.
                ViewBag.Mensagem = $"Olá de novo, {nomeUsuario}!";
            }

            // Tenta obter a contagem de visitas da sessão.
            int? contagemVisitas = HttpContext.Session.GetInt32("ContagemVisitas");
            if (contagemVisitas == null)
            {
                contagemVisitas = 0;
            }

            contagemVisitas++;
            HttpContext.Session.SetInt32("ContagemVisitas", (int)contagemVisitas);

            ViewBag.Contagem = contagemVisitas;
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
    }
}
