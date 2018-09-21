using System.Collections.Generic;
using System.Linq;
using Aula04_AppPeople_ef.Models;
using Microsoft.EntityFrameworkCore;

namespace AppPeople.Models
{
    public class PersonRepository : IPersonRepository
    {    
        private DataContext dataContext;
        public PersonRepository(DataContext dataContext)
        {           
            this.dataContext = dataContext;
        }

        public void Create(Person person)
        {
            person.city = 
                dataContext.Cities.Find(person.city.id);

            dataContext.Add(person);
            dataContext.SaveChanges();
        }
        public List<Person> GetAll()
        {
            return dataContext.People.Include(x=>x.city).ToList();
        }
        
        public void Update(Person person)
        {
            var obj  = GetById(person.id);
            
            obj.name = person.name;
            obj.address = person.address;
            
            dataContext.SaveChanges();
        }
        public Person GetById(int id)
        {
            return dataContext.People.SingleOrDefault(x=>x.id == id);
        }
        
        public void Delete(int id)
        {
            dataContext.Remove(GetById(id));
            dataContext.SaveChanges();
        }

        
    }
}