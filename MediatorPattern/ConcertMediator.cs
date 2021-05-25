using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorPattern
{
    public class ConcertMediator : Mediator
    {
        ConcertColleague1 concertColleague1;
        ConcertColleague2 concertColleague2;

        public ConcertMediator()
        {
            this.concertColleague2 = new ConcertColleague2(this);
            this.concertColleague1 = new ConcertColleague1(this);
        }


        public override void Changed(Colleague colleague)
        {
            if (colleague is ConcertColleague1)
            {
                concertColleague2.Notify();
            }
            else if (colleague is ConcertColleague2)
            {
                concertColleague1.Notify();
            }
        }

        public void SumilatedMediator()
        {
            // concertColleague1 take to concertColleague2 and VS
            concertColleague1.Content = "Get concert1";
            concertColleague2.Content = "Get concert2";
        }
    }
}
