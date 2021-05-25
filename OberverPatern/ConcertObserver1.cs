using System;
using System.Collections.Generic;
using System.Text;

namespace OberverPatern
{
    public class ConcertObserver1 : Observer
    {
        private ConcertSubject _subject;

        public ConcertObserver1(ConcertSubject subject)
        {
            _subject = subject;
        }

        public void Update()
        {
            Console.WriteLine($"Concert Class one Notified Name is {_subject.GetValue()}");
        }
    }
}
