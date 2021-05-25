using System;

namespace StatesPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Context context = new Context();

            context.CurrentState = new ConcreteStateA();

            context.MouseDown();

            context.CurrentState = new ConcreteStateB();
            context.MouseUp();
        }
    }
}
