using System.Collections.Generic;
using AppPeople.Models;

namespace Aula05_AppPeople_ef_one_to_many.Models
{
    public class City
    {        
        public int id { get; set; }
        public string name  { get; set; } 

        public List<Person> people { get; set; }       
    }
}