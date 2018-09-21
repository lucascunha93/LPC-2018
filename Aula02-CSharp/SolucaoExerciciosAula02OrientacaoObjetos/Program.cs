using System;
using System.Text;
using SolucaoExerciciosAula02OrientacaoObjetos.Models;

namespace SolucaoExerciciosAula02OrientacaoObjetos
{
    class Program
    {
        static void Main(string[] args)
        {
            //aqui setei o enconding para aceitar utf8 e tratar o pt-br (mostrar acentos, ç,)
            Console.OutputEncoding = Encoding.UTF8;

            #region 01 02

            Cliente c1 = new Cliente(12,"Cássio");
            Cliente c2 = new Cliente(14,"Alice");

            W("Cliente01: " + c1.id + "-" + c1.nome);
            W("Cliente02: " + c2.id + "-" + c2.nome);
            R();

            #endregion

            #region 03 04
                
            CartaoDeCredito cartaoDoCassio = new CartaoDeCredito(c1,232323,new DateTime(2020,09,01));
            CartaoDeCredito cartaoDaAline = new CartaoDeCredito(c2,343434,new DateTime(2030,01,01));

            W("Cartão de: " + cartaoDoCassio.cliente.nome + "núm: " + cartaoDoCassio.numero + " Validade: " + cartaoDoCassio.dataValidade.ToString("dd/MM/yyyy"));
            W("Cartão de: " + cartaoDaAline.cliente.nome + "núm: " + cartaoDaAline.numero + " Validade: " + cartaoDaAline.dataValidade.ToString("dd/MM/yyyy"));
            
            R();

            #endregion

            #region 05 06

            Agencia torres = new Agencia(778,"Agencia de Torres RS");
            W(torres.descricao + "N: " + torres.numero);
            R();
                
            #endregion

            #region 07 08

            Conta doCassio = new Conta(1414, 1000,5000,torres);
            Conta daAlice = new Conta(666,500,1000,torres);

            W("Dados da conta: " + doCassio.numero + 
              "\nLimite: " + doCassio.limite.ToString("0.00") + 
              "\nSaldo: " + doCassio.saldo.ToString("0.00"));
            W("---------------");
            W("Dados da conta: " + daAlice.numero + 
              "\nLimite: " + daAlice.limite.ToString("0.00") + 
              "\nSaldo: " + daAlice.saldo.ToString("0.00"));
            R();
            #endregion

            #region 11
                
            //depositar na conta do cassio
            W("Saldo Atual Cássio: " + doCassio.saldo);
            W("depositou 1000 para Cássio");
            doCassio.Depositar(1000);
            W("Saldo Atual cassio: " + doCassio.saldo);//deve retornar 2000;
            R();

            //sacar 100 da conta do cassio
            W("sacou 100 no Cássio");
            doCassio.Sacar(100);
            W("Saldo Atual do Cássio: " + doCassio.saldo);//deve retornar 1900;
            R();

            //transferir 500 para a conta da aline
            W("Saldo Atual alice: " + daAlice.saldo);//deve retornar 500;
            W("transferiu 500 do cassio para a alice");
            doCassio.Transferir(daAlice,500);
            W("---------------");            
            W("Saldo Atual da alice: " + daAlice.saldo);//deve retornar 1000;
            W("Saldo Atual do cassio: " + doCassio.saldo);//deve retornar 1400;
            R();

            #endregion

            #region 12

                Gerente silva = new Gerente(123,"João da Silva", 1000);
                W("Salario atual do joão é " + silva.salario);
                W("aumentar o salário do joão");
                silva.AumentarSalario();
                W("salário atual do joão é " + silva.salario);

                W("Aumentar em 5% o sal do joão");
                silva.AumentarSalario(5);
                W("salário atual do joão é " + silva.salario);
                R();
            #endregion

        }

        //função simples só pra não ficar escrevendo console.WriteLine :)
        private static void W(string msg)
        {
            Console.WriteLine(msg);
        }
        //função simples só pra não ficar escrevendo console.ReadLine :)
        private static void R()
        {
            Console.WriteLine("Pressione qualquer tecla para continuar");
            Console.ReadLine();
        }

    }
}
