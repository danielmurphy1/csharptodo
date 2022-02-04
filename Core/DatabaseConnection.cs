using Microsoft.Extensions.Configuration;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DotNetEnv;


namespace Core
{
    public class DatabaseConnection
    {
        
        public NpgsqlConnection GetConnection()
        {
            Env.TraversePath().Load();
            //string connString = "host=localhost;Port=5432;Database=test_todos;Username=postgres;Password=pitdline";
            string connString = System.Environment.GetEnvironmentVariable("SECRET");

            NpgsqlConnection conn = new NpgsqlConnection(connString);
            conn.Open();
            return conn;
        }

    }
}
