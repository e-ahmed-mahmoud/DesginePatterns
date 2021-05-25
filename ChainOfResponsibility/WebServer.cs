using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibilityPattern
{
    public class WebServer
    {
        private Handler _pipeline;

        public WebServer(Handler pipline)
        {
            _pipeline = pipline;
        }

        public void Handle(HttpRequest httpRequest)
        {
            _pipeline.Handle(httpRequest);
        }
    }
}
