using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorPattern
{
    public class ConcertColleague1 : Colleague
    {
        private string _content;

        public string GetValue()
        {
            return _content;
        }

        public override void Notify()
        {
            Console.WriteLine("Concert 1 Notify");
        }

        public string Content
        {
            set
            {
                _content = value;
                Console.WriteLine("ConcertColleague1 is changed");
                mediator.Changed(this);
            }
        }

        public ConcertColleague1(Mediator mediator):base(mediator)
        {

        }
    }
}
