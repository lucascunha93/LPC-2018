namespace Aula07_interfaces_basic
{
    public class PrinterFactory
    {
        public  static IPrinter GetInstance(string marca)
        {
            switch (marca)
            {
                case "daruma":
                    return new Daruma();
                case "elgin":
                    return new Elgin();
                default:
                    return null;
            }
        }
    }
}