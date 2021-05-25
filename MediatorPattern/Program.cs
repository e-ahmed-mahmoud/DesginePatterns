using System;

namespace MediatorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*********** Mediator Pattern ***********");

            ConcertMediator concertMediator = new ConcertMediator();
            concertMediator.SumilatedMediator();
            
        }
    }
}
