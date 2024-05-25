using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;
using System;

namespace SenaFotology.Controllers
{
    public class HomeController : Controller
    {
        private readonly string _connectionString;

        public HomeController(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DefaultConnection");
        }

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

        public IActionResult RegistroUsuario()
        {
            return View();
        }

        public IActionResult RegistroFotografo()
        {
            return View();
        }

        public IActionResult RegistroAdministrador()
        {
            return View();
        }

        public IActionResult PaginaFotografo()
        {
            return View();
        }

        public IActionResult PagAdministrador()
        {
            return View();
        }

        public IActionResult Ayuda()
        {
            return View();
        }

        [HttpPost]
        public IActionResult InicioUsuario(string email, string password)
        {
            if (AuthenticateUser(email, password))
            {
                return RedirectToAction("PaginaCliente", "Cliente");
            }
            else
            {
                ViewData["Error"] = "Correo electrónico o contraseña inválidos.";
                return View();
            }
        }

        private bool AuthenticateUser(string email, string password)
        {
            using (var connection = new MySqlConnection(_connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT COUNT(*) FROM Cliente WHERE Email = @Email AND Contrasena = @Password";
                    using (var command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Email", email);
                        command.Parameters.AddWithValue("@Password", password);

                        var result = Convert.ToInt32(command.ExecuteScalar());
                        return result > 0;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                    return false;
                }
            }
        }
    }
}
