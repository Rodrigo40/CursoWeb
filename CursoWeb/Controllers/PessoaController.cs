using CursoWeb.Models;
using Microsoft.AspNetCore.Mvc;

namespace CursoWeb.Controllers
{
    public class PessoaController : Controller
    {
        public IActionResult Index()
        {
            return View(Pessoa.GetInstancia());
            //return View("Adicionar");
        }
        [BindProperty]
        public string nome { get; set; }
        [BindProperty]
        public int ano { get; set; }
        [BindProperty]
        public double altura { get; set; }
        public IActionResult Adicionar()
        {
            if (!string.IsNullOrEmpty(nome) && ano != 0 && altura != 0)
            {
                Pessoa pessoa = new Pessoa()
                {
                    Nome = nome,
                    AnoNascimento = ano,
                    Altura = altura
                };
                ViewBag.msg = Pessoa.GetInstancia().Adicionar(pessoa);
                //return RedirectToAction("Index");

            }
            return View();
        }
        public IActionResult LimparLista()
        {
            Pessoa.GetInstancia().GetPessoa().Clear();
            return RedirectToAction("Index");
        }
    }
}
