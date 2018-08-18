using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeroConta;
            string nomeCorrentista;
            
            
            double saldo = 1000;

            numeroConta = 12334;

            numeroConta =Convert.ToInt32(Console.ReadLine());

            Cliente leo = new Cliente();
            leo.nome = "LEonardo";
            leo.fone = "2323232323";

            // Conta umaConta = new Conta();
            // umaConta.id= 122;
            // umaConta.cliente = 
            //         new Cliente 
            //         {
            //             id =1,
            //             nome = "Leo",
            //             fone =" 3343434"
            //         };
            // umaConta.saldo = 1000;

            // umaConta.cliente.nome = "Leo Silva";
            // Console.WriteLine(umaConta.cliente.nome);

            // umaConta.Sacar(200);

            Conta cunha = 
                new Conta(122, new Cliente {id=3434,nome= "Ç" },2000);
            
            
            cunha.cliente = new Cliente {id=3434,nome= "Ç"};
            cunha.cliente.nome = "Lucas Cunha";
            cunha.cliente.fone = "234234234";
            cunha.saldo = 30000;


            // umaConta.Transferir(cunha,200);
            
        }
    }
}
