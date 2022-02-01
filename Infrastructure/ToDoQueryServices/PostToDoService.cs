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
        public List<ToDoModel> PostToDo(string text)
        {
            DatabaseConnection dbConnection = new DatabaseConnection();
            var connection = dbConnection.GetConnection();
            var newToDo = new List<ToDoModel>();
            using var command = new NpgsqlCommand("INSERT INTO test_todos_info (todo_text, is_complete, created_at) VALUES ($1, $2, NOW()) RETURNING *", connection)
            {
                Parameters =
                {
                    new() { Value = text},
                    new() { Value = false}
                }

            };

            command.ExecuteNonQueryAsync();
            return newToDo;
        }
    }
}
