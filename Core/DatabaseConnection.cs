using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Core
{
    internal class DatabaseConnection
    {
        public NpgsqlConnection GetConnection()
        {
            string connString = "host=localhost;Username=postres;Password=pitdline;Database=test_todos;Port=5432";

            NpgsqlConnection conn = new NpgsqlConnection(connString);
            conn.Open();
            return conn;
        }
    }
}
