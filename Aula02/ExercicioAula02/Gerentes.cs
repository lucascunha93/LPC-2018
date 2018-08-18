namespace ExercicioAula02
{
    public class Gerentes
    {
        public double salario;
        public string nome;

        public Gerentes(double s, string n) {
            this.nome = n;
            this.salario = s;
        }

        public void aumentaSalario() {
            this.salario += this.salario*0.10;
        }

        public void aumentaSalario(double valor){
            this.salario += this.salario*valor;
        }
    }
}