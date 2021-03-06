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
    public class GetToDoService
    {
        private static NpgsqlConnection _npgsqlconnection;
        public List<ToDoModel> GetTodos()
        {
            DatabaseConnection dbConnection = new DatabaseConnection();
            using (var connection = dbConnection.GetConnection())
            {
                var todos = new List<ToDoModel>();
                using NpgsqlCommand command = new NpgsqlCommand("SELECT * FROM todos_info ORDER BY id", connection);

                using var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    ToDoModel todo = new ToDoModel
                    {
                        Id = reader.GetInt32(0),
                        Text = reader.GetString(1),
                        IsComplete = reader.GetBoolean(2),
                        CreatedAt = reader.GetDateTime(3)
                    };
                    todos.Add(todo);
                }

                return todos;
            } ;
            
        }
    }
}
