using System;
using System.ComponentModel.DataAnnotations;
using Chamados.Models;

namespace chamados.Models
{
    public class Chamado
    {
        public Chamado()
        {

        }

        public Chamado(int id, string descricaoProblema, DateTime horaInicio, DateTime horaFim,string situacao)
        {
            this.id = id;
            this.descricaoProblema = descricaoProblema;
            this.horaInicio = horaInicio;
            this.horaFim = horaFim;
            this.situacao=situacao;
        }

        public int id { get; set; }
        public string descricaoProblema { get; set; }
        public DateTime horaInicio { get; set; }
        public DateTime horaFim { get; set; }
        public TimeSpan duracao { get; set; }
        public Cliente cliente{get;set;}
        public string situacao{get;set;}
    }
}