using System.Collections.Generic;
using Chamados.Models;

namespace chamados.Models
{
    public interface IClienteRepository
    {

        Cliente GetById(int id);

        List<Cliente>GetAll();

        void Create(Cliente cliente);

        void Delete(int id);

        void Update(Cliente cliente);
    }
}