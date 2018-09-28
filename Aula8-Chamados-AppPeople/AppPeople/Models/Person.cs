namespace AppPeople.Models
{
    public class Person
    {
        public Person() {}
        
        public Person(int id, string name, string address, int age, City city)
        {
            this.id = id;
            this.name = name;
            this.city = city;
        }

        public int id { get; set; }
        public string name { get; set; }
        
        public City city { get; set; }
    }
}