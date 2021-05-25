using System;
using System.Collections.Generic;
using System.Text;

namespace MementoPattern
{
    public class Caretaker
    {
        private readonly List<Memento> States = new List<Memento>();

        public void Push(Memento memento)
        {
            States.Add(memento);
        }

        public Memento Pop()
        {
            if (States.Count < 1)
                throw new ArgumentNullException("Empty List");

            var state = States[States.Count - 1];
            States.Remove(States[States.Count - 1]);

            return state;
        }

    }
}
