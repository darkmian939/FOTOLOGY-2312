using Microsoft.AspNetCore.Mvc;
using SenaFotology.Models;

namespace SenaFotology.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Ayuda()
        {
            return View();
        }

        public ActionResult InicioUsuario()
        {
            return View();
        }

        public ActionResult InicioFotografo()
        {
            return View();
        }

        public ActionResult InicioAdministrador()
        {
            return View();
        }

        [HttpPost]
        public ActionResult LoginUsuario(string email, string password, bool mantenerSesion)
        {
            // Lógica de autenticación para el usuario
            if (email == "usuario@example.com" && password == "password")
            {
                // Autenticación exitosa
                // Redirigir al dashboard de usuario o página principal
                return RedirectToAction("DashboardUsuario");
            }
            else
            {
                ViewData["Error"] = "Usuario o contraseña incorrectos.";
                return View("InicioUsuario");
            }
        }

        [HttpPost]
        public ActionResult LoginFotografo(string username, string password, bool mantenerSesion)
        {
            // Lógica de autenticación para el fotógrafo
            if (username == "fotografo" && password == "password")
            {
                // Autenticación exitosa
                // Redirigir al dashboard de fotógrafo o página principal
                return RedirectToAction("DashboardFotografo");
            }
            else
            {
                ViewData["Error"] = "Usuario o contraseña incorrectos.";
                return View("InicioFotografo");
            }
        }

        [HttpPost]
        public ActionResult LoginAdministrador(string usuario, string contraseña, bool mantenerSesion)
        {
            // Lógica de autenticación para el administrador
            if (usuario == "admin" && contraseña == "password")
            {
                // Autenticación exitosa
                // Redirigir al dashboard de administrador o página principal
                return RedirectToAction("DashboardAdministrador");
            }
            else
            {
                ViewData["Error"] = "Usuario o contraseña incorrectos.";
                return View("InicioAdministrador");
            }
        }

        public ActionResult DashboardUsuario()
        {
            return View();
        }

        public ActionResult DashboardFotografo()
        {
            return View();
        }

        public ActionResult DashboardAdministrador()
        {
            return View();
        }
    }
}


