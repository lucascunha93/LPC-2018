using System.Collections.Generic;

namespace chamados.Models
{
    public interface IChamadoRepository
    {

        Chamado GetById(int id);

        List<Chamado>GetAll();

        void Create(Chamado chamado);

        void Delete(int id);

        void Update(Chamado chamado);
    }
}