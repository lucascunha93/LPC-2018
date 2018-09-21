using System.Collections.Generic;
using AppPeople.Models;

namespace Aula04_AppPeople_ef.Models
{
    public interface IPersonRepository
    {
        void Create(Person person);
        List<Person> GetAll();
        void Update(Person person);
        Person GetById(int id);
        void Delete(int id);
    }
}