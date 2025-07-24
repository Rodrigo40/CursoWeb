using CursoWeb.Models;
using Microsoft.AspNetCore.Mvc;

namespace CursoWeb.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Novo()
        { 
            return View();
        }
        [BindProperty]
        public string login { get; set; }
        [BindProperty]
        public string password { get; set; }
        public IActionResult Login()
        {
            UserModel user = new UserModel();
            user.Login = login;
            user.Password = password;
            return View(user);
        }
        public IActionResult Editar()
        {
            return View();
        }
    }
}
