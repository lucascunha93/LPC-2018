namespace ToDoList.Domain
{
    public class Item
    {
        public int id { get; set; }
        public string nome { get; set; }
        public ToDo todo { get; set; }
    }
}