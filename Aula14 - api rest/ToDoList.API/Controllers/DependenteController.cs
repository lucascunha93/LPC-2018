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
    public class DependenteController : Controller
    {

        private readonly Idependente repository;

        public DependenteController(Idependente repository) {
            this.repository = repository;
        }

        // POST api/values
        [HttpPost]
        public IActionResult Post([FromBody]dependente item)
        {
            this.repository.Create(item);
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
