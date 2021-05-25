using System;
using System.Collections.Generic;

namespace IteratorPattern
{
    public class Container
    {
        private readonly List<string> _li = new List<string>();

        public Container(List<string> list)
        {
            _li = list;
        }

        public void Push(string a)
        {
            _li.Add(a);
        }

        public string Pop()
        {
            if (_li.Count < 0)
            {
                throw new IndexOutOfRangeException();
            }
            else
            {
                int index = _li.Count - 1;
                string data = _li[index];
                _li.RemoveAt(index);
                return data;
            }
        }
        public IIterator<List<string>> CreateIterator()
        {
//            var arr = new int[] { 2, 5 };
            return new ListIterator<List<string>>(_li);
        }
   
        public class ListIterator<T> : IIterator<T>
        {
            private readonly T _collection;
            private int _index;
            public ListIterator(T container,int index=0)
            {
                _collection = container ;
                _index = index;
            }
            public object Current()
            {
                var value =( _collection is Array ? (_collection as Array).GetValue(_index): (_collection as List<string>)[_index]);
                return value;
            }

            public bool IsDone()
            {
                if (_collection is Array)
                {
                    if (_index < (_collection as Array).Length)
                        return true;
                    else
                        return false;
                }
                else if (_collection is List<string>)
                {
                    if (_index < (_collection as List<string>).Count)
                        return true;
                    else
                        return false;
                }
                else
                    throw new ArgumentException();
            }

            public void Next()
            {
                if (IsDone())
                    _index++;
            }
        }
    }
}
