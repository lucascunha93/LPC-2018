using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using ToDoList.Domain;
using ToDoList.Repositories.Interfaces;

namespace ToDoList.Repositories
{
    public class UserRepository : IUserRepository
    {
        private DataContext dataContext;
        public UserRepository(DataContext dataContext)
        {           
            this.dataContext = dataContext;
        }

        public void Create(User user)
        {
            dataContext.Entry(user).State = EntityState.Added;
            dataContext.SaveChanges();
        }
        public List<User> GetAll()
        {
            return dataContext.Users.ToList();
        }
        
        public void Update(User user)
        {            
            dataContext.Entry(user).State = EntityState.Modified;           
            dataContext.SaveChanges();
        }
        public User GetById(int id)
        {
            return dataContext.Users.SingleOrDefault(x=>x.id == id);
        }
        
        public void Delete(int id)
        {
            dataContext.Remove(GetById(id));
            dataContext.SaveChanges();
        }
        public User AuthUser(User user){

            return dataContext
            .Users
            .SingleOrDefault(i.name=>user.name && i.password==user.password);
        }
    }
}