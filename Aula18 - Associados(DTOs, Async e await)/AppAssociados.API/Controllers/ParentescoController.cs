using System.Collections.Generic;
using AppAssociados.Domain;
using AppAssociados.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;
using ToDoList.API.DTOs;

namespace AppAssociados.API.Controllers
{
    [Route("api/[controller]")]
    public class ParentescoController : Controller
    {
        private readonly IParentescoRepository repository;

        public ParentescoController(IParentescoRepository repository) {
            this.repository = repository;
        }

        [HttpGet]
        public IEnumerable<ParentescoDTO> Get()
        {
            var parentescos = this.repository.GetAll();
            var parentescosDTO = new List<ParentescoDTO>();

            parentescos.ForEach(parentesco => {
                parentescosDTO.Add(
                    new ParentescoDTO{
                        id = parentesco.id, 
        
                        name = parentesco.descricao
                    }
                );
            });

            return parentescosDTO;
        }

        [HttpGet("{id}")]
        public Parentesco Get(int id)
        {
            return this.repository.GetById(id);
        }

        [HttpPost]
        public IActionResult Post([FromBody]Parentesco parentesco)
        {
            this.repository.Create(parentesco);
            return Ok(parentesco);
        }

        [HttpPut]
        public IActionResult Put([FromBody]Parentesco parentesco)
        {
            this.repository.Update(parentesco);
            return Ok(parentesco);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            this.repository.Delete(id);
            return Ok(new {
                message = "Deletado com sucesso!"
            });
        }
    }
}