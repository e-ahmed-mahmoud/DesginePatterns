using System;
using System.Collections.Generic;
using System.Text;

namespace OberverPatern
{
    public class Subject
    {
        private readonly List<Observer> _observers = new List<Observer>();

        public void AddObserver(Observer observer)
        {
            _observers.Add(observer);
        }

        public void RemoverObserver(Observer observer)
        {
            _observers.Remove(observer);
        }

        public void Notify()
        {
            foreach (var observer in _observers)
            {
                observer.Update();
            }
        }
    }
}
