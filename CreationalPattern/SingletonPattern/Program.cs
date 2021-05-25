using System;

namespace SingletonPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("************* Singleton Pattern ************* ");

            Singleton singleton = Singleton.GetInstance();
            singleton.AccessSingleton();
            var singleton2 = Singleton.GetInstance();
            singleton2.AccessSingleton();
        }
    }
}
