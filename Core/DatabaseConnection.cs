using Microsoft.Extensions.Configuration;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Core
{
    public class DatabaseConnection
    {
        //private readonly IConfiguration configuration;
        //public DatabaseConnection(IConfiguration configuration)
        //{
        //    this.configuration = configuration;
        //}
        public NpgsqlConnection GetConnection()
        {
            string connString = "host=localhost;Port=5432;Database=test_todos;Username=postgres;Password=pitdline";
            //string connString = configuration.GetConnectionString("Default");

            NpgsqlConnection conn = new NpgsqlConnection(connString);
            conn.Open();
            return conn;
        }

    }
}
