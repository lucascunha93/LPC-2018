namespace Aula07_interfaces_basic
{
    public class Elgin : IPrinter
    {
        public string Close()
        {
            return "fechou";
        }

        public string Open()
        {
            throw new System.NotImplementedException();
        }

        public string Print()
        {
            throw new System.NotImplementedException();
        }
    }
}