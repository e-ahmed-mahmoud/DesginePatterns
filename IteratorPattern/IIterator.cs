using System;
using System.Collections.Generic;
using System.Text;

namespace IteratorPattern
{
    public interface IIterator <T>
    {
        bool IsDone();

        object Current();

        void Next();
    }
}
