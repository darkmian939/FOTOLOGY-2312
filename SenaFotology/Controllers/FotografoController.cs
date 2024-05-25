using Microsoft.AspNetCore.Mvc;
using SenaFotology.Models;
using static SenaFotology.Models.LoginViewModel;

namespace SenaFotology.Controllers
{
    public class FotografoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Indexfotografo()
        {
            return View();
        }

        public ActionResult IniciarSesionFotografo()
        {
            return View();
        }

        public ActionResult PaginaCategorias()
        {
            return View();
        }

        public ActionResult PaginaFotografo()
        {
            return View();
        }

        public ActionResult PaginaAyuda()
        {
            return View();
        }

        public ActionResult PaginaContacto()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult IniciarSesionFotografo(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                if (IsValidUser(model.Email, model.Clave))
                {
                    return RedirectToAction("PaginaFotografo");
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Credenciales inválidas");
                    return View(model);
                }
            }
            return View(model);
        }

        private bool IsValidUser(string email, string clave)
        {
            return (email == "usuario@dominio.com" && clave == "contraseña");
        }

        [HttpGet]
        public ActionResult RegistroFotografo()
        {
            return View();
        }

        public ActionResult olvidocontraseñaFot()
        {
            return View();
        }

        [HttpPost]
        public ActionResult RegistroFotografo(RegistroFotografoViewModel model)
        {
            return RedirectToAction("Index");
        }
    }
}
