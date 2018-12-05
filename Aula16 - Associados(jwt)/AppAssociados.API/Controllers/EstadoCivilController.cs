using System.Collections.Generic;
using AppAssociados.Domain;
using AppAssociados.Repositories.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AppAssociados.API.Controllers
{
    [Route("api/[controller]")]
    public class EstadoCivilController : Controller
    {
        private readonly IEstadoCivilRepository repository;

        public EstadoCivilController(IEstadoCivilRepository repository) {
            this.repository = repository;
        }

        [Authorize]
        [HttpGet]
        public IEnumerable<EstadoCivil> Get()
        {
            return this.repository.GetAll();
        }

        [HttpGet("{id}")]
        public EstadoCivil Get(int id)
        {
            return this.repository.GetById(id);
        }

        [HttpPost]
        public IActionResult Post([FromBody]EstadoCivil estadoCivil)
        {
            if(ModelState.IsValid) {
                this.repository.Create(estadoCivil);
                return Ok(estadoCivil);
            } else {
                var errors = new List<string>();
                foreach(var state in ModelState) {
                    foreach(var error in state.Value.Errors) {
                        errors.Add(error.ErrorMessage);
                    }
                }

                return BadRequest(new {
                    message = errors
                });
            }
        }

        [HttpPut]
        public IActionResult Put([FromBody]EstadoCivil estadoCivil)
        {
            this.repository.Update(estadoCivil);
            return Ok(estadoCivil);
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