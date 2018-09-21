namespace HelloWorld
{
    public class Conta
    {

        public Conta(int id, Cliente cliente, 
                        double saldo)
        {
                this.id = id;
                this.cliente = cliente;
                this.saldo = saldo;

                //depostiar();
        }    

        public int id;
        public Cliente cliente;
        public double saldo;

        public void Sacar(double valor)
        {

        }

        public void Transferir(Conta contaDestino, double valor)
        {

        }
    }
}