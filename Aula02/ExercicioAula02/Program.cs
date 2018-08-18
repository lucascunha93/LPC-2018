using System;

namespace ExercicioAula02
{
    class Program
    {
        static void Main(string[] args)
        {
            Clientes cliente1 = new Clientes("Gilto", 1);
            Clientes cliente2 = new Clientes("Cassio", 2);

            Cartoes cartao1 = new Cartoes(1, "03/19");
            Cartoes cartao2 = new Cartoes(2, "03/21");

            Agencias agencia1 = new Agencias(1);
            Agencias agencia2 = new Agencias(2);

            Contas conta1 = new Contas(1, 300, cliente1);
            Contas conta2 = new Contas(2, 200, cliente2);

            Console.WriteLine("CARTOES");

            Console.WriteLine("O numero do cartão 1 é: " +cartao1.getNumero());
            Console.WriteLine("A data de validade do cartão 1 é: " +cartao1.getDataValidade());

            Console.WriteLine(" ");
            
            Console.WriteLine("O numero do cartão 2 é: " +cartao2.getNumero());
            Console.WriteLine("A data de validade do cartão 2 é: " +cartao2.getDataValidade());

            Console.WriteLine(" ");

            Console.WriteLine("AGENCIAS");

            Console.WriteLine("O numero da agencia 1 é: " +agencia1.getNumero());
            Console.WriteLine("O numero da agencia 2 é: " +agencia2.getNumero());

            Console.WriteLine(" ");

            Console.WriteLine("O numero da conta 1 é: " + conta1.getNumero());
            Console.WriteLine("O saldo da conta 1 é: " + conta1.getSaldo());
            Console.WriteLine("O limite da conta 1 é: " + conta1.getLimite());
            Console.WriteLine("O titular da conta 1 é: " + conta1.getTitular());

            Console.WriteLine(" ");

            Console.WriteLine("O numero da conta 2 é: " + conta2.getNumero());
            Console.WriteLine("O saldo da conta 2 é: " + conta2.getSaldo());
            Console.WriteLine("O limite da conta 2 é: " + conta2.getLimite());
            Console.WriteLine("O titular da conta 2 é: " + conta2.getTitular());
        }
    }
}
