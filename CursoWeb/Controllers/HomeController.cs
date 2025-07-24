using System.Diagnostics;
using CursoWeb.Models;
using Microsoft.AspNetCore.Mvc;

namespace CursoWeb.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        public IActionResult MetodosPage(string valor1, string valor2)
        {
            ViewData["valor1"] = valor1;
            ViewData["valor2"] = valor2;
            ViewData["result"] = Multiplicar(Convert.ToDouble(valor1), Convert.ToDouble(valor2));
            return View();
        }
        private double Multiplicar(double v1,double v2)
        {
            return v1 * v2;
        }
        public IActionResult Index()
        {
            return View();
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
    }
}
