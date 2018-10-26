using System;
using System.ComponentModel.DataAnnotations;

namespace chamados.Models
{
    public class Chamado
    {
        public Chamado()
        {

        }

        public Chamado(int id, int numChamado, int numSolicitante, string telefone, string email, string descricaoProblema, DateTime horaInicio, DateTime horaFim)
        {
            this.id = id;
            this.numChamado = numChamado;
            this.numSolicitante = numSolicitante;
            this.telefone = telefone;
            this.email = email;
            this.descricaoProblema = descricaoProblema;
            this.horaInicio = horaInicio;
            this.horaFim = horaFim;
        }

        public int id { get; set; }
        public int numChamado { get; set; }
        public int numSolicitante { get; set; }
        public string telefone { get; set; }
        public string email { get; set; }
        public string descricaoProblema { get; set; }
        public DateTime horaInicio { get; set; }
        public DateTime horaFim { get; set; }
        public TimeSpan duracao { get; set; }
    }
}