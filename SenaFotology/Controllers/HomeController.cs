using Microsoft.AspNetCore.Mvc;
using SenaFotology.Models;

namespace SenaFotology.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult InicioUsuario()
        {
            return View();
        }

        public IActionResult InicioFotografo()
        {
            return View();
        }

        public IActionResult InicioAdministrador()
        {
            return View();
        }

        // Otros métodos del controlador...

        public IActionResult Ayuda()
        {
            return View();
        }

        // Otros métodos del controlador...
    }
}


