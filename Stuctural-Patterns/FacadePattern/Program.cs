using System;

namespace FacadePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*********** Facade Pattern ************ ");
            Facade facade = new Facade();
            facade.Send("hello world", "localhost");
        }
    }
}
