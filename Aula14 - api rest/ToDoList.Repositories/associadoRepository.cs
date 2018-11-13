using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using ToDoList.Domain;

namespace ToDoList.Repositories
{
    public class associadoRepository : IAssociado
    {
        private DataContext dataContext;
        public associadoRepository(DataContext dataContext)
        {           
            this.dataContext = dataContext;
        }

        public void Create(associado associado)
        {
            dataContext.Add(associado);
            dataContext.SaveChanges();
        }
        public List<associado> GetAll()
        {
            return dataContext.associado.ToList();
        }
        
        public void Update(associado associado)
        {
            var obj  = GetById(associado.id);
            
            obj.id = associado.id;
            obj.nome= associado.nome;
            obj.cpf=associado.cpf;
            obj.dataCreate=associado.dataCreate;
            obj.endereco=associado.endereco;
            obj.cidade=associado.cidade;
            obj.cep=associado.cep;
            obj.uf=associado.uf;
            obj.email=associado.email;
            obj.estadoCivil=associado.estadoCivil;
            obj.dataNascimento=associado.dataNascimento;
            
            dataContext.SaveChanges();
        }
        public associado GetById(int id)
        {
            return dataContext.associado.SingleOrDefault(x=>x.id == id);
        }
        
        public void Delete(int id)
        {
            dataContext.Remove(GetById(id));
            dataContext.SaveChanges();
        }
    }
}
