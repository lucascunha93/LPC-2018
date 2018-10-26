namespace AppPeople.Models
{
    public class Person
    {
        public Person() {}
        
        public Person(int id, string name, string address, int age)
        {
            this.id = id;
            this.name = name;
            this.address = address;
            this.age = age;
        }

        public int id { get; set; }
        public string name { get; set; }
        public string address { get; set; }
        public int age { get; set; }
        
    }
}