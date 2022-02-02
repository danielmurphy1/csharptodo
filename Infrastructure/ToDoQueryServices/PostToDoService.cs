using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core;
using Core.Models;
using Npgsql;

namespace Infrastructure.ToDoQueryServices
{
    public class PostToDoService
    {
        public ToDoModel PostToDo(string text)
        {
            DatabaseConnection dbConnection = new DatabaseConnection();
            var connection = dbConnection.GetConnection();
            using var command = new NpgsqlCommand("INSERT INTO test_todos_info (todo_text) VALUES (@p1)", connection)
            {
                Parameters =
                {
                    new NpgsqlParameter("p1", text)
                }
            };

            command.ExecuteNonQuery(); 
                                       
            return new ToDoModel { Text = text };
        }
    }
}
