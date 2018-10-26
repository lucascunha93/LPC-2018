using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace chamados.Models
{
    public class ChamadoRepository : IChamadoRepository
    {
        
        private DataContext context;

        public ChamadoRepository(DataContext context) {
            this.context = context;
        }

        public Chamado GetById(int id) {
            return context.Chamado.SingleOrDefault(x => x.id == id);
        }

        public List<Chamado> GetAll() {
            return context.Chamado.ToList();
        }

        public void Create(Chamado chamado) {
            chamado.duracao = chamado.horaFim.Subtract(chamado.horaInicio);

            context.Chamado.Add(chamado);
            context.SaveChanges();
        }

        public void Delete(int id)
        {

            context.Chamado.Remove(GetById(id));
            context.SaveChanges();
        }

        public void Update(Chamado chamado)
        {
            chamado.duracao = chamado.horaFim.Subtract(chamado.horaInicio);
            
            context.Entry(chamado).State = EntityState.Modified;
            context.SaveChanges();
        }
    }
}