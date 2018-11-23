using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using ToDoList.Domain;

namespace ToDoList.Repositories
{
    public class ToDoRepository : ITodoRepository
    {
        private DataContext dataContext;
        public ToDoRepository(DataContext dataContext)
        {           
            this.dataContext = dataContext;
        }

        public void Create(ToDo todo)
        {
            dataContext.Entry(todo).State = EntityState.Added;
            dataContext.SaveChanges();
        }
        public List<ToDo> GetAll()
        {
            return dataContext.Todos.Include(i => i.items).ToList();
        }
        
        public void Update(ToDo todo)
        {            
            dataContext.Entry(todo).State = EntityState.Modified;           
            dataContext.SaveChanges();
        }
        public ToDo GetById(int id)
        {
            return dataContext.Todos.Include(i => i.items).SingleOrDefault(x=>x.id == id);
        }
        
        public void Delete(int id)
        {
            dataContext.Remove(GetById(id));
            dataContext.SaveChanges();
        }
    }
}
