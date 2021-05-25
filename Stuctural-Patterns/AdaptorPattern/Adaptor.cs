using System;
using System.Collections.Generic;
using System.Text;

namespace AdaptorPattern
{
    public class Adaptor : Client
    {
        private readonly Service _service;

        public Adaptor(Service service)
        {
            _service = service;
        }

        public void ClientMethod()
        {
            Console.WriteLine("override Client Method from Adaptor");
            _service.ServiceMethod();

        }
    }
}
