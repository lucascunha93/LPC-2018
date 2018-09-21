namespace SolucaoExerciciosAula02OrientacaoObjetos.Models
{
    public class Conta
    {
        
        public int numero { get; set; }
        public double saldo { get; set; }
        public double limite { get; set; }
        
        //exercício 14
        public string referencia { get; set; }

        public Agencia agencia { get; set; }

        public Conta(int numero, double saldo, double limite, Agencia agencia)
        {
            this.numero = numero;
            this.saldo = saldo;            
            this.limite = 100;
            this.agencia = agencia;            

            //exercício 09 - testei para o caso de ser informado o limite então considera
            if(limite > 0)
                this.limite = limite;
            else                
                this.limite = 100;
        }

        //exercício 14
        public Conta(int numero, double saldo, double limite, Agencia agencia, string referencia)
        {
            this.numero = numero;
            this.saldo = saldo;            
            this.limite = 100;
            this.agencia = agencia;            

            //exercício 09 - testei para o caso de ser informado o limite então considera
            if(limite > 0)
                this.limite = limite;
            else                
                this.limite = 100;

            this.referencia = referencia;
        }

        public void Depositar(double valor)
        {
            this.saldo += valor;
        }
        public void Sacar(double valor)
        {
            this.saldo-= valor;
        }

        public double GetSaldo()
        {
            return this.saldo;
        }

        public void Transferir(Conta destino, double valor)
        {
            this.saldo -= valor;
            destino.saldo += valor;
        }
    }
}
