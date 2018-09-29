using System;

namespace AppConsulta.Models
{
    public class Consulta
    {
        public Consulta() {}

        public Consulta( int id, Paciente paciente, DateTime hraConsulta, string tipo, int valor ) {
            this.id = id;
            this.paciente = paciente;
            this.hraConsulta = hraConsulta;
            this.tipo = tipo;
            this.valor = valor;
        }

        public int id { get; set; }

        public Paciente paciente { get; set; }

        public DateTime hraConsulta { get; set; }

        public string tipo { get; set; }

        public int valor { get; set; }

        public int? hrFinal { get; set; }
    }
}