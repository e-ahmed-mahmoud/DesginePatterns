using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonPattern
{
    class Singleton
    {
        private static Singleton singleton;
        
        private Singleton()
        {
        
        }

        public static Singleton GetInstance()
        {
            if (singleton == null)
            {
                singleton = new Singleton();
            }
            return singleton;

        }

        public void AccessSingleton()
        {
            Console.WriteLine($"Single instance access {singleton}");
        }
    }
}
