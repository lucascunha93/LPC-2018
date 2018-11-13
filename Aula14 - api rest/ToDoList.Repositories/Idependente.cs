using System.Collections.Generic;
using ToDoList.Domain;
namespace ToDoList.Repositories
{
    public interface Idependente
    {
       void Create(dependente dependente);
       dependente GetById(int id);
       void Delete(int id);  
    }
}