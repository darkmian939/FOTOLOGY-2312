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
                    cmd.CommandText = "SELECT email FROM users";
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            users.Add(reader.GetString("email"));
                        }
                    }
                }
            }

            ViewBag.Users = users;
            return View();
        }

        [HttpPost]
        public IActionResult InicioUsuario(string email, string password)
        {
            if (AuthenticateUser(email, password))
            {
                // Redirect to the client page or dashboard if login is successful
                return RedirectToAction("PaginaCliente", "Cliente");
            }
            else
            {
                // Show an error message if login fails
                ViewData["Error"] = "Invalid email or password.";
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
                    string query = "SELECT COUNT(*) FROM users WHERE email = @Email AND password = @Password";
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
