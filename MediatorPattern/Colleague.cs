using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorPattern
{

    //can be interface or abstract class more common is abstract class
    public abstract class Colleague
    {
        protected Mediator mediator;

        protected Colleague(Mediator mediator)
        {
            this.mediator = mediator;
        }

        //for notify other ConcertColleague about change
        public abstract void Notify();
    }
}
