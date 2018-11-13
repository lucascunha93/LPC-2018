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
    public class AssociadoController : Controller
    {

        private readonly IAssociado repository;

        public AssociadoController(IAssociado repository) {
            this.repository = repository;
        }

        // GET api/get
        [HttpGet]
        public IEnumerable<associado> Get()
        {
            return this.repository.GetAll();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public associado Get(int id)
        {
            return this.repository.GetById(id);
        }

        // POST api/values
        [HttpPost]
        public IActionResult Post([FromBody]associado item)
        {
            this.repository.Create(item);
            return Ok(item);
        }

        // PUT api/values/5
        [HttpPut]
        public IActionResult Put([FromBody]associado item)
        {
            repository.Update(item);
            return Ok(item);
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            this.repository.Delete(id);
            return Ok(new {
                message = "Deletado com sucesso."
            });
        }
    }
}