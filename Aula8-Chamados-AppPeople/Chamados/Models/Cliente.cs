using System;
using System.ComponentModel.DataAnnotations;
using Chamados.Models;
namespace Chamados.Models
{
    public class Cliente
    {
        public Cliente()
        {

        }

        public Cliente(int id,string nome, string email, string telefone)
        {
            this.id=id;
            this.nome=nome;
            this.email=email;
            this.telefone=telefone;
        }
        public int id{get;set;}
        public string nome{get;set;}
        public string email{get;set;}
        public string telefone{get;set;}
    }
}