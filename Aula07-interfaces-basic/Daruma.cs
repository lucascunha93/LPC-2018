namespace Aula07_interfaces_basic
{
    public class Daruma : IPrinter
    {
        public string Open()
        {
            return "abrir daruma";
        }
        
        public string Print()
        {
            return "imprimindo daruma";
        }
        
        public string Close()
        {
            return "fechei daruma";
        }
    }
}