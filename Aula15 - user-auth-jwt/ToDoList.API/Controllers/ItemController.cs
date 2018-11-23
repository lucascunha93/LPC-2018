using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using ToDoList.Domain;
using ToDoList.Repositories;

namespace ToDoList.API.Controllers
{
    [Route("api/[controller]")]
    public class ItemController : Controller
    {
        public readonly IItemRepository _itemRepository;

        public ItemController(IItemRepository itemRepository)
        {
            this._itemRepository = itemRepository;
        }


        // GET api/todos
        [HttpGet]
        public IEnumerable<Item> Get()
        {
            return this._itemRepository.GetAll();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public Item Get(int id)
        {
            return this._itemRepository.GetById(id);
        }

        // POST api/values
        [HttpPost]
        public IActionResult Post([FromBody]Item item)
        {
            this._itemRepository.Create(item);
            return Ok(item);
        }

        // PUT api/values/5
        [HttpPut]
        public IActionResult Put([FromBody]Item item)
        {
            this._itemRepository.Update(item);
            return Ok(item);
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            this._itemRepository.Delete(id);
            return Ok(new {
                message = "Deletado com sucesso.",
                id = id
            });
        }


    }
}