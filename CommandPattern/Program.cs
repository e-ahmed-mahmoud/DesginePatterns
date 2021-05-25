using System;

namespace CommandPattern
{
    class Program
    { 
        static void Main(string[] args)
        {
            Console.WriteLine("************ Command Pattern ************ ");

            var eventReciever = new EventReciver();
            var eventReciever2 = new EventReciver2();

            var compasitCommand = new CompasitCommand();
            compasitCommand.Add(new ConcertCommand(eventReciever));
            compasitCommand.Add(new ConcertCommand2(eventReciever2));

            var eventInvokr = new EventInvoker(compasitCommand);
            eventInvokr.SendEvent();
            
        }
    }
}
