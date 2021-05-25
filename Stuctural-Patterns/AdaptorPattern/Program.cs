using System;

namespace AdaptorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("************ Adaptor Pattern *************");

            var adaptor = new Adaptor(new Service());
            adaptor.ClientMethod();
        }
    }
}
