using Microsoft.AspNetCore.Mvc;
using SenaFotology.Models;
using static SenaFotology.Models.LoginViewModel;

namespace SenaFotology.Controllers
{
    public class RegistroController : Controller
    {
        // GET: /Registro/IndexCliente
        public ActionResult RegistroUsuario()
        {
            return View();
        }

        // GET: /Registro/CreateCliente
        public ActionResult CreateCliente()
        {
            return View();
        }

        // POST: /Registro/CreateCliente
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateCliente(RegistroUsuarioViewModel model)
        {
            // Lógica para registrar un Cliente
            return RedirectToAction("RegistroUsuario");
        }

        // GET: /Registro/IndexFotografo
        public ActionResult RegistroFotografo()
        {
            return View();
        }

        // GET: /Registro/CreateFotografo
        public ActionResult CreateFotografo()
        {
            return View();
        }

        // POST: /Registro/CreateFotografo
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateFotografo(RegistroFotografoViewModel model)
        {
            // Lógica para registrar un Fotógrafo
            return RedirectToAction("RegistroFotografo");
        }
    }
}
