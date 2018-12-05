using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Text;
using AppAssociados.Domain;
using AppAssociados.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;

namespace AppAssociados.API.Controllers
{
    [Route("api/[controller]")]
    public class UsuarioController : Controller
    {
        private readonly IUsuarioRepository repository;

        public UsuarioController(IUsuarioRepository repository) {
            this.repository = repository;
        }

        [HttpGet]
        public IEnumerable<Usuario> Get()
        {
            return this.repository.GetAll();
        }

        [HttpGet("{id}")]
        public Usuario Get(int id)
        {
            return this.repository.GetById(id);
        }

        [HttpPost]
        public IActionResult Post([FromBody]Usuario usuario)
        {
            this.repository.Create(usuario);
            return Ok(usuario);
        }

        [HttpPut]
        public IActionResult Put([FromBody]Usuario usuario)
        {
            this.repository.Update(usuario);
            return Ok(usuario);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            this.repository.Delete(id);
            return Ok(new {
                message = "Deletado com sucesso!"
            });
        }

        [HttpPost("auth")]
        public IActionResult Authentication([FromBody]Usuario user)
        {
            var usuario = this.repository.AuthUser(user);

            if(usuario == null)
                return BadRequest(new {
                    message = "Usuário incorreto."
                });

            return Ok(new {
                token = BuildToken()
            });
        }

        public string BuildToken()
        {
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("TokenAppAssociadosTeste"));
            var creed = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(
                audience: "AppAssociados",
                issuer: "AppAssociados",
                signingCredentials: creed
            );

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}