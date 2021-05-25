using System;

namespace OberverPatern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("********** Oberser Pattern *********** ");

            var concertSubject = new ConcertSubject();

            var subscriber1 = new ConcertObserver1(concertSubject);
            var subscriber2 = new ConcertObserver2(concertSubject);

            concertSubject.AddObserver(subscriber1);
            concertSubject.AddObserver(subscriber2);

            concertSubject.Name="Ahmed";


        }
    }
}
