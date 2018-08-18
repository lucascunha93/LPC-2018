namespace ExercicioAula02
{
    public class Cartoes
    {
        int numero;
        string dataValidade;

        public Cartoes(int numero, string dataValidade) {
            this.numero = numero;
            this.dataValidade = dataValidade;
        }

        public int getNumero(){
            return numero;
        }

        public string getDataValidade() {
            return dataValidade;
        }
    }
}