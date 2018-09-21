namespace SolucaoExerciciosAula02OrientacaoObjetos.Models
{
    public class Gerente
    {
        public int id { get; set; }
        public string nome { get; set; }
        public double salario { get; set; }

        public Gerente(int id, string nome, double salario)
        {
            this.id = (id == 0 ? 0 : id);
            this.nome = nome;
            this.salario = salario;

        }

        public void AumentarSalario()
        {
            this.salario = this.salario * 1.10;
        }

        public void AumentarSalario(double percTaxa)
        {
            this.salario += (this.salario * percTaxa)/100; 
        }

    }
}