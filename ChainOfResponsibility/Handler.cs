using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibilityPattern
{
    public abstract class Handler
    {
        private Handler _next;

        protected Handler(Handler next)
        {
            _next = next;
        }

        public void Handle(HttpRequest httpRequest)
        {
            if (DoHandler(httpRequest))
            {
                return;
            }

            if (_next != null )
            {
                _next.Handle(httpRequest);
            }

        }

        protected abstract bool DoHandler(HttpRequest httpRequest);
    }
}
