using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ToDoList.Domain;
using ToDoList.Repositories;
using ToDoList.Repositories.Interfaces;

namespace ToDoList.API.Controllers
{
    [Route("api/[controller]")]
    public class UsersController : Controller
    {   
        private readonly IUserRepository repository;
        public UsersController(IUserRepository repository){
            this.repository = repository;
        }
        // GET api/todos
        [HttpGet]
        public IEnumerable<User> Get()
        {
            return this.repository.GetAll();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public User Get(int id)
        {
            return this.repository.GetById(id);
        }

        // POST api/Todos
        [HttpPost]
        public IActionResult Post([FromBody]User item)
        {
            this.repository.Create(item);
            return Ok(item);
        }

        // PUT api/Todos/
        [HttpPut]
        public IActionResult Put([FromBody]User item)
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
        public Authentication(User user){
            var usuario=this.repository.AuthUser(user);
            if(usuario == null){
                return Unauthorized;
            }
            return Ok( new User(
             token = BuildToken();   
            ));
        }
            public string BuildToken(){
            var key = new SymetricSecurityKey(Encoding.UTF8.GetBytes("aula15"));
            var creed = new SigninCredentials(Key,SecurityAlgoritms.MaxSize256);
            var token = new JmtSecurityToken(
                audience:"aula15",
                issuer:"aula15",
                SigninCredentials:creed

            );
            return new JmtSecurityTokenHandler().writeToken(token);
                
            return "aaa";
        }

    }
}