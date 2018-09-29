using System.Collections.Generic;
using AppConsulta.Models;

namespace AppConsulta.Models
{
    public interface IConsultaRepository
    {
        Consulta GetById(int id);

        List<Consulta>GetAll();

        void Create(Consulta consulta);

        void Delete(int id);

        void Update(Consulta consulta);
    }
}