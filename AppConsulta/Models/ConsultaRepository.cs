using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using AppConsulta.Models;

namespace AppConsulta.Models
{
    public class ConsultaRepository: IConsultaRepository
    {
        private DataContext context;

        public ConsultaRepository(DataContext context) {
            this.context = context;
        }

        public Consulta GetById(int id) {
            return context.Consultas.SingleOrDefault(x => x.id == id);
        }

        public List<Consulta> GetAll() {
            return context.Consultas.ToList();
        }

        public void Create(Consulta consulta) {
            context.Consultas.Add(consulta);
            context.SaveChanges();
        }

        public void Delete(int id)
        {

            context.Consultas.Remove(GetById(id));
            context.SaveChanges();
        }

        public void Update(Consulta consulta)
        { 
            context.Entry(consulta).State = EntityState.Modified;
            context.SaveChanges();
        }
    }
}