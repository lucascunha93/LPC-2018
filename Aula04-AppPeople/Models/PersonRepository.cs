using System.Collections.Generic;

namespace AppPeople.Models
{
    public class PersonRepository
    {

        public static List<Person> people = new List<Person>();
    
        public PersonRepository()
        {           
        }

        public void Create(Person person)
        {
            people.Add(person);
        }
        public List<Person> GetAll()
        {
            return people;
        }
        
        public void Update(Person person)
        {
            var index  = people.FindIndex(x=>x.id == person.id);
            people[index].name = person.name;
            people[index].address = person.address;

        }
        public Person GetById(int id)
        {
            return people.Find(x=>x.id == id);
        }


        
        public void Delete(int id)
        {
            people.Remove(GetById(id));

        }

        
    }
}