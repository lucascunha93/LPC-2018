using System;

namespace SolucaoExerciciosAula02OrientacaoObjetos.Models
{
    public class CartaoDeCredito
    {

        public int numero { get; set; }
        public DateTime dataValidade { get; set; }

        //Exercício 10 - vinculo entre cliente e cartão de crédito
        public Cliente cliente { get; set; }


        public CartaoDeCredito(Cliente cliente, int numero, DateTime dataValidade)
        {
            this.cliente = cliente;
            this.numero = numero;
            this.dataValidade = dataValidade;
        }
    }
}