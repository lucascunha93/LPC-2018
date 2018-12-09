using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AppAssociados.Domain;
using AppAssociados.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace AppAssociados.Repositories
{
    public class DependenteRepository : IDependenteRepository
    {
        private DataContext context;

        public DependenteRepository(DataContext context)
        {
            this.context = context;
        }

        public void Create(Dependente obj)
        {
            obj.associado = context.Associado.Find(obj.associado.id);
            obj.parentesco = context.Parentesco.Find(obj.parentesco.id);
            context.Dependente.Add(obj);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            context.Dependente.Remove(GetById(id));
            context.SaveChanges();
        }

        public List<Dependente> GetAll()
        {
            return context.Dependente.Include(a => a.associado).Include(p => p.parentesco).ToList();
        }

        public Task<List<Dependente>> GetAllAsync()
        {
            throw new System.NotImplementedException();
        }

        public Dependente GetById(int id)
        {
            return context.Dependente.Include(a => a.associado).Include(p => p.parentesco).SingleOrDefault(x => x.id == id);
        }

        public Task<Dependente> GetByIdAsync(int id)
        {
            throw new System.NotImplementedException();
        }

        public void Update(Dependente obj)
        {
            obj.associado = context.Associado.Find(obj.associado.id);
            obj.parentesco = context.Parentesco.Find(obj.parentesco.id);
            context.Entry(obj).State = EntityState.Modified;
            context.SaveChanges();
        }

        
    }
}