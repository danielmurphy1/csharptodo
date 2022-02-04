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
    public class UpdateToDoService
    {
        public ToDoModel UpdateToDo(int id, bool isComplete)
        {
            DatabaseConnection dbConnection = new DatabaseConnection();
            var connection = dbConnection.GetConnection();
            var updatedTodo = new ToDoModel();
            using var command = new NpgsqlCommand("UPDATE test_todos_info SET is_complete = @p1 WHERE id = @p2 RETURNING *", connection)
            {
                Parameters =
                {
                    new NpgsqlParameter("p1", isComplete),
                    new NpgsqlParameter("p2", id)
                }
            };

            var reader = command.ExecuteReader();

            while (reader.Read())
            {
                updatedTodo = new ToDoModel
                {
                    Id = reader.GetInt32(0),
                    Text = reader.GetString(1),
                    IsComplete = isComplete,
                    CreatedAt = reader.GetDateTime(3)
                };
            }
            return updatedTodo;
        }
    }
}
