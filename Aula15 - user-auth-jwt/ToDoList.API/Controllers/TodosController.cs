using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ToDoList.Domain;
using ToDoList.Repositories;

namespace ToDoList.API.Controllers
{
    [Route("api/[controller]")]
    public class TodosController : Controller
    {   
        private readonly ITodoRepository repository;
        public TodosController(ITodoRepository repository){
            this.repository = repository;
        }
        // GET api/todos
        [HttpGet]
        public IEnumerable<ToDo> Get()
        {
            return this.repository.GetAll();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ToDo Get(int id)
        {
            return this.repository.GetById(id);
        }

        // POST api/Todos
        [HttpPost]
        public IActionResult Post([FromBody]ToDo item)
        {
            this.repository.Create(item);
            return Ok(item);
        }

        // PUT api/Todos/
        [HttpPut]
        public IActionResult Put([FromBody]ToDo item)
        {
            this.repository.Update(item);
            return Ok(item);
        }

        // DELETE api/Todos/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            this.repository.Delete(id);
            return Ok(new {
                message = "Deletado com sucesso.",
                id = id
            });
        }
    }
}
