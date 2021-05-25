using System;

namespace TemplateMathodPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*********** Template Method Pattern *********");

            TaskContext task1 = new ConcreteClass1(new RecorderCommanBehaviour());
            TaskContext task2 = new ConcreteClass2(new RecorderCommanBehaviour());

            task1.Execute();
            task2.Execute();
        }
    }
}
