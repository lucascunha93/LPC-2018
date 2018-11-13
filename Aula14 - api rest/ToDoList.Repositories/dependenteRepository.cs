using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using ToDoList.Domain;
namespace ToDoList.Repositories
{
    public class dependenteRepository: Idependente
    {
        private DataContext dataContext;
        public dependenteRepository(DataContext dataContext)
        {           
            this.dataContext = dataContext;
        }

        public void Create(dependente dependente)
        {
            dataContext.Add(dependente);
            dataContext.SaveChanges();
        }
         public dependente GetById(int id)
        {
            return dataContext.dependente.SingleOrDefault(x=>x.id == id);
        }
        public void Delete(int id)
        {
            dataContext.Remove(GetById(id));
            dataContext.SaveChanges();
        }
    }
    }
