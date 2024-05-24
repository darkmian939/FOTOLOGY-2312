using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using SenaFotology.Data;
using System.Collections.Generic;
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

        public IActionResult Ayuda()
        {
            return View();
        }

        public IActionResult GetUsers()
        {
            List<string> users = new List<string>();

            using (var db = new DatabaseContext(_connectionString))
            {
                db.OpenConnection();

                using (var cmd = db.CreateCommand())
                {
                    cmd.CommandText = "SELECT Email FROM Cliente";
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            users.Add(reader.GetString("Email"));
                        }
                    }
                }
            }

            ViewBag.Users = users;
            return View();
        }

        public IActionResult GetFotografos()
        {
            List<string> fotografos = new List<string>();

            using (var db = new DatabaseContext(_connectionString))
            {
                db.OpenConnection();

                using (var cmd = db.CreateCommand())
                {
                    cmd.CommandText = "SELECT Email FROM Fotografo";
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            fotografos.Add(reader.GetString("Email"));
                        }
                    }
                }
            }

            ViewBag.Fotografos = fotografos;
            return View();
        }

        public IActionResult GetAdministradores()
        {
            List<string> administradores = new List<string>();

            using (var db = new DatabaseContext(_connectionString))
            {
                db.OpenConnection();

                using (var cmd = db.CreateCommand())
                {
                    cmd.CommandText = "SELECT Email FROM Administrador";
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            administradores.Add(reader.GetString("Email"));
                        }
                    }
                }
            }

            ViewBag.Administradores = administradores;
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
                ViewData["Error"] = "Invalid Email or password.";
                return View();
            }
        }

        [HttpPost]
        public IActionResult InicioFotografo(string email, string password)
        {
            if (AuthenticateFotografo(email, password))
            {
                return RedirectToAction("PagFotografo", "Fotografo");
            }
            else
            {
                ViewData["Error"] = "Invalid Username or password.";
                return View();
            }
        }

        [HttpPost]
        public IActionResult InicioAdministrador(string email, string password)
        {
            if (AuthenticateAdministrador(email, password))
            {
                return RedirectToAction("PagAdministrador", "Administrador");
            }
            else
            {
                ViewData["Error"] = "Invalid Username or password.";
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

        private bool AuthenticateFotografo(string email, string password)
        {
            using (var connection = new MySqlConnection(_connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT COUNT(*) FROM Fotografo WHERE Email = @Email AND Contrasena = @Password";
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

        private bool AuthenticateAdministrador(string email, string password)
        {
            using (var connection = new MySqlConnection(_connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT COUNT(*) FROM Administrador WHERE Email = @Email AND Contrasena = @Password";
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
