using System;
using System.ComponentModel.DataAnnotations;

namespace AppConsulta.Models
{
    public class Paciente
    {
        public Paciente() {}

        public Paciente( int id, string nome, 
                         string endereco, string email, 
                         string telefone, DataType nascimento, 
                         string tipo, string convenio ) {
            this.id = id;
            this.nome = nome;
            this.endereco = endereco;
            this.email = email;
            this.telefone = telefone;
            this.nascimento = nascimento;
            this.convenio = convenio;
        }

        public int id { get; set; }

        public string nome { get; set; }

        public string endereco { get; set; }

        public string email { get; set; }

        public string telefone { get; set; }

        public DataType nascimento { get; set; }

        public string tipo { get; set; }

        public string convenio { get; set; }

    }
}