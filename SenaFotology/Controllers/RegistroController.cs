using Microsoft.AspNetCore.Mvc;
using static SenaFotology.Models.LoginViewModel;
namespace SenaFotology.Controllers
{
    public class RegistroController : Controller
    {
        // GET: /Registro/Index
        public ActionResult Index()
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
            // Lógica para registrar un fotógrafo
            return RedirectToAction("Index");
        }

        // GET: /Registro/CreateUsuario
        public ActionResult CreateUsuario()
        {
            return View();
        }

        // POST: /Registro/CreateUsuario
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateUsuario(RegistroUsuarioViewModel model)
        {
            // Lógica para registrar un usuario
            return RedirectToAction("Index");
        }

        // Resto de las acciones del controlador para Editar, Borrar, etc.
    }
}
