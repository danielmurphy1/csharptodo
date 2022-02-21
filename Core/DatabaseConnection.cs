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
            //string connString = Environment.GetEnvironmentVariable("DEVELOPMENT_CONNECTION_STRING");
            string connString = Environment.GetEnvironmentVariable("PRODUCTION_CONNECTION_STRING");

            NpgsqlConnection conn = new NpgsqlConnection(connString);
            conn.Open();
            return conn;
        }

    }
}
