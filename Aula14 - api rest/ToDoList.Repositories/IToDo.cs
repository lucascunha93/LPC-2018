using System.Collections.Generic;
using ToDoList.Domain;

namespace ToDoList.Repositories
{
    public interface IToDo
    {
        void Create(ToDo person);
        List<ToDo> GetAll();
        void Update(ToDo todo);
        ToDo GetById(int id);
        void Delete(int id);
    }
}