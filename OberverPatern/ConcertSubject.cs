using System;
using System.Collections.Generic;
using System.Text;

namespace OberverPatern
{
    public class ConcertSubject : Subject
    {
        private string _name;
        public string GetValue() => this._name;
        public string Name {
            set { 
                this._name = value;
                Notify(); 
            }
        }
    }
}
