using System.Collections.Generic;
using ToDoList.Domain;

namespace ToDoList.Repositories
{
    public interface ITodoRepository  
            : IRepositoryBase<ToDo>
    {
        
    }
}