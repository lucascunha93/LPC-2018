using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using AppConsulta.Models;

namespace AppConsulta.Models
{
    public class PacienteRepository : IPacienteRepository
    {
        
        private DataContext context;

        public PacienteRepository(DataContext context) {
            this.context = context;
        }

        public Paciente GetById(int id) {
            return context.Pacientes.SingleOrDefault(x => x.id == id);
        }

        public List<Paciente> GetAll() {
            return context.Pacientes.ToList();
        }

        public void Create(Paciente paciente) {
            context.Pacientes.Add(paciente);
            context.SaveChanges();
        }

        public void Delete(int id)
        {

            context.Pacientes.Remove(GetById(id));
            context.SaveChanges();
        }

        public void Update(Paciente paciente)
        { 
            context.Entry(paciente).State = EntityState.Modified;
            context.SaveChanges();
        }
    }
}