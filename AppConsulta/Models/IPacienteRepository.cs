using System.Collections.Generic;
using AppConsulta.Models;

namespace AppConsulta.Models
{
    public interface IPacienteRepository
    {

        Paciente GetById(int id);

        List<Paciente>GetAll();

        void Create(Paciente paciente);

        void Delete(int id);

        void Update(Paciente paciente);
    }
}