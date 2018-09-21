using System;

namespace Aula07_interfaces_basic
{
    class Program
    {
        static string marca;
        static void Main(string[] args)
        {
            IPrinter printer = PrinterFactory.GetInstance("daruma");
            
            printer.Open();
            printer.Print();
            printer.Close();
            
            Console.WriteLine("Hello World!");

        }
    }
}
