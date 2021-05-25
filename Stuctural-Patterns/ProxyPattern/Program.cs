using System;

namespace ProxyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("************* Proxy Pattern *************** ");
            var client = new Client();
            string [] names = new string[]{ "a","b","c"};
            foreach (var item in names)
            {
                client.Add(Name: item, subject: new Proxy());
            }
            client.Show("a");
            client.Show("b");
        }
    }
}
