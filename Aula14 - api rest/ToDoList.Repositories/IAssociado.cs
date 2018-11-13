using System.Collections.Generic;
using ToDoList.Domain;

namespace ToDoList.Repositories
{
    public interface IAssociado
    {
        void Create(associado person);
        List<associado> GetAll();
        void Update(associado associado);
        associado GetById(int id);
        void Delete(int id);
    }
}