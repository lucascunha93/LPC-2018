using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using ToDoList.Domain;

namespace ToDoList.Repositories
{
    public class ItemRepository : IItemRepository
    {
        private DataContext dataContext;
        public ItemRepository(DataContext dataContext)
        {           
            this.dataContext = dataContext;
        }

        public void Create(Item todo)
        {
            dataContext.Add(todo);
            dataContext.SaveChanges();
        }
        public List<Item> GetAll()
        {
            return dataContext.Items.ToList();
        }
        
        public void Update(Item item)
        {
            dataContext.Entry(item).State = EntityState.Modified;   
            dataContext.SaveChanges();
        }
        public Item GetById(int id)
        {
            return dataContext.Items.SingleOrDefault(x=>x.id == id);
        }
        
        public void Delete(int id)
        {
            dataContext.Remove(GetById(id));
            dataContext.SaveChanges();
        }
    }
}