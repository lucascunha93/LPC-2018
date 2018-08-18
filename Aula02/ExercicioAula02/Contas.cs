using System;

namespace ExercicioAula02
{
    public class Contas
    {
        int numero;
        double saldo;
        double limite = 100;
        string referencia;

        Clientes titular = new Clientes();

        public Contas(int n, double s, Clientes t) {
            this.numero = n;
            this.saldo = s;
            this.titular = t;
        }

        public Contas(int n, double s, Clientes t, string r) {
            this.numero = n;
            this.saldo = s;
            this.titular = t;
            this.referencia = r;
        }

        public int getNumero(){
            return numero;
        }

        public double getSaldo() {
            return saldo;
        }

        public double getLimite() {
            return limite;
        }

        public string getTitular() {
            return titular.nome;
        }

        public void deposita(double valor){
            this.saldo += valor;

            Console.WriteLine("Seu novo saldo é de: "+this.saldo);
        }

        public void saca(double valor){
            this.saldo -= valor;

            Console.WriteLine("Seu novo saldo é de: "+this.saldo);
        }

        public void consultaSaldo(){
            Console.WriteLine("Seu saldo é de: "+this.saldo);
        }   

        public void transfere(Contas destino, double valor) {
            destino.deposita(valor);

            this.saca(valor);

            Console.WriteLine("Seu novo saldo é de: " +this.saldo);
        }
    }
}