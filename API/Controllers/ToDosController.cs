using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Core;
using Core.Models;
using Npgsql;
using Infrastructure.ToDoQueryServices;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class ToDosController : ControllerBase
    {


        // GET: api/<ToDosController>
        [HttpGet]
        public List<ToDoModel> Get()
        {
            var getToDoService = new GetToDoService();
            var todos = getToDoService.GetTodos();

            return todos;

        }

        // GET api/<ToDosController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ToDosController>
        [HttpPost]
        public ToDoModel Post([FromBody] ToDoModel todo)
        {
            var postToDoService = new PostToDoService();
            var text = todo.Text;
            var newTodo = postToDoService.PostToDo(text);

            return new ToDoModel { Text = text };
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
