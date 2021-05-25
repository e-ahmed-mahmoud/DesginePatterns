using System;
using System.Collections.Generic;
using System.Text;

namespace ProxyPattern
{
    public class Client
    {
        private Dictionary <string  , Subject> Subjects= new Dictionary<string, Subject>();
        

        public void Show(string Name)
        {
            (Subjects.GetValueOrDefault(Name)).Request();
        }
        public void Add(string Name, Subject subject)
        {
            Subjects.Add(Name, subject);
        }

    }
}
