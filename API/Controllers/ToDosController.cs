using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Core;
using Npgsql;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class ToDosController : ControllerBase
    {


        // GET: api/<ToDosController>
        [HttpGet]
        public string Get()
        {
            DatabaseConnection dbConnection = new DatabaseConnection();
            var connection = dbConnection.GetConnection();
            NpgsqlCommand command  = new NpgsqlCommand("SELECT todo_text FROM test_todos_info", connection);
            var reader = command.ExecuteReader();
            string value = "";
            while (reader.Read())
            {
                value = reader.GetString(0);
            }

            return value;
        }

        // GET api/<ToDosController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ToDosController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ToDosController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ToDosController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
