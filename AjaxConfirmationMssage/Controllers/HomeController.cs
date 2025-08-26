using AjaxConfirmationMssage.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace AjaxConfirmationMssage.Controllers
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
            CriarItens();//Carregar os itens no load da pagina
            return View();
        }
        public IActionResult Apagar(string id)
        {
            LinguagemModel.Instancia.lista.RemoveAll(l => l.Id == id);
            return Ok(); // HTTP 200
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
        public void CriarItens()
        {
            if (LinguagemModel.Instancia.lista.Count == 0)
            {
                LinguagemModel.Instancia.lista.AddRange(new LinguagemModel[]
                {
                new LinguagemModel
                {
                Id=Guid.NewGuid().ToString().Substring(4,8),
                Nome = "Java",
                Tipagem = "Forte de mais",
                DataCricao = DateTime.Now.ToShortTimeString(),
                }, new LinguagemModel
                {
                Id=Guid.NewGuid().ToString().Substring(4,8),
                Nome = "C#",
                Tipagem = "Forte de mais",
                DataCricao = DateTime.Now.ToShortTimeString(),
                }, new LinguagemModel
                {
                Id=Guid.NewGuid().ToString().Substring(4,8),
                Nome = "Python",
                Tipagem = "Forte de mais",
                DataCricao = DateTime.Now.ToShortTimeString(),
                }, new LinguagemModel
                {
                Id=Guid.NewGuid().ToString().Substring(4,8),
                Nome = "Ruby",
                Tipagem = "Forte de mais",
                DataCricao = DateTime.Now.ToShortTimeString(),
                },

                });
            }
        }

    }
}
