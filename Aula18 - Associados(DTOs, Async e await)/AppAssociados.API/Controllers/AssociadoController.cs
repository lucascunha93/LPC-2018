using System.Collections.Generic;
using System.Threading.Tasks;
using AppAssociados.Domain;
using AppAssociados.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace AppAssociados.API.Controllers
{
    [Route("api/[controller]")]
    public class AssociadoController : Controller
    {
        private readonly IAssociadoRepository repository;

        public AssociadoController(IAssociadoRepository repository) {
            this.repository = repository;
        }

        [HttpGet]
        public async Task<IEnumerable<Associado>> Get()
        {
            return await this.repository.GetAllAsync();
        }

        [HttpGet("{id}")]
        public async Task<Associado> Get(int id)
        {
            return await this.repository.GetByIdAsync(id);
        }

        [HttpPost]
        public IActionResult Post([FromBody]Associado associado)
        {
            this.repository.Create(associado);
            return Ok(associado);
        }

        [HttpPut]
        public IActionResult Put([FromBody]Associado associado)
        {
            this.repository.Update(associado);
            return Ok(associado);
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