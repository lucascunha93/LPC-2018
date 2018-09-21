namespace SolucaoExerciciosAula02OrientacaoObjetos.Models
{
    public class Agencia
    {
        public int numero { get; set; }
        public string descricao { get; set; }

        public Agencia(int numero, string descricao)
        {
            this.numero = numero;
            this.descricao = descricao;
        }

        // exercício 13
        public Agencia(int numero)
        {
            this.numero = numero;
        }
    }
}