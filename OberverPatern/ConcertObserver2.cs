using System;
using System.Collections.Generic;
using System.Text;

namespace OberverPatern
{
    public class ConcertObserver2 : Observer
    {
        private ConcertSubject _subject;

        public ConcertObserver2(ConcertSubject subject)
        {
            _subject = subject;
        }

        public void Update()
        {
            Console.WriteLine($"Concert Class Two Notified Name is {_subject.GetValue()}");
        }
    }
}
