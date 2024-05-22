using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace SenaFotology.Data
{
    public class DatabaseContext : IDisposable
    {
        private readonly MySqlConnection _connection;

        public DatabaseContext(string connectionString)
        {
            _connection = new MySqlConnection(connectionString);
        }

        public void OpenConnection()
        {
            if (_connection.State == ConnectionState.Closed)
                _connection.Open();
        }

        public void CloseConnection()
        {
            if (_connection.State == ConnectionState.Open)
                _connection.Close();
        }

        public MySqlCommand CreateCommand()
        {
            return _connection.CreateCommand();
        }

        public void Dispose()
        {
            CloseConnection();
            _connection.Dispose();
        }
    }
}
