using System.Collections.Generic;

namespace AppChamados.Models
{
    public interface ISituacaoRepository
    {
         Situacao GetById(int id);
         List<Situacao> GetAll();
         void Create(Situacao situacao);
         void Delete(int id);
         void Update(Situacao situacao);
    }
}