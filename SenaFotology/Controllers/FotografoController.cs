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
            // Aquí puedes devolver la vista de la página principal del fotógrafo
            return View();
        }

        // GET: Fotografo/IniciarSesionFotografo
        public ActionResult IniciarSesionFotografo()
        {
            return View();
        }
        public ActionResult PaginaCategorias()
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


        // POST: Fotografo/IniciarSesionFotografo
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult IniciarSesionFotografo(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                // Aquí deberías implementar la lógica de autenticación
                // Verifica el correo electrónico y la contraseña en tu base de datos
                // En un escenario real, reemplaza el siguiente código con tu propia lógica

                if (IsValidUser(model.Email, model.Clave))
                {
                    // Redirige a la página principal del fotógrafo después de un inicio de sesión exitoso
                    return RedirectToAction("PagFotografo");
                }
                else
                {
                    // Redirige de nuevo a la página de inicio de sesión con un mensaje de error
                    ModelState.AddModelError(string.Empty, "Credenciales inválidas");
                    return View(model);
                }
            }
            // Si hay errores de validación, vuelve a mostrar la vista de inicio de sesión con los errores
            return View(model);
        }

        // Método de simulación de validación de usuario
        private bool IsValidUser(string email, string clave)
        {
            // Simulación de validación simple
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
            // Aquí deberías implementar la lógica de registro de usuario
            // Guarda la información del usuario en la base de datos
            // En un escenario real, reemplaza el siguiente código con tu propia lógica

            // Redirige a la página de inicio de sesión después de un registro exitoso
            return RedirectToAction("Index");
        }
    }
}
