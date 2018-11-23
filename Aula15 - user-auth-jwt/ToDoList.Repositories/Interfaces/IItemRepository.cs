using System.Collections.Generic;
using ToDoList.Domain;

namespace ToDoList.Repositories
{
    public interface IItemRepository  
            : IRepositoryBase<Item>
    {
        
    }
}