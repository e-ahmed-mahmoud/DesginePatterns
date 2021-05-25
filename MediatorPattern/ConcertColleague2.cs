using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorPattern
{
    public class ConcertColleague2 : Colleague
    {
        private string _content; 
        public string Content
        {
            get { return _content; }
            set {
                _content = value;
                Console.WriteLine("ConcertColleague2 is changed");
                mediator.Changed(this); 
            }
        }

        public override void Notify()
        {
            Console.WriteLine("Concert 2 Notify");
        }

        public ConcertColleague2(Mediator mediator) : base(mediator)
        {

        }
    }
}
