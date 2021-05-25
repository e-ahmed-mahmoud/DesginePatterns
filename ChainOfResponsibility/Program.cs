using System;

namespace ChainOfResponsibilityPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("********** Chain of Responsibility Pattern ************* ");

            HttpRequest httpRequest = new HttpRequest() { UserName = "admin", Pass = "133" };
            
            //define pipeline in reverse so last object define firest and pass to its previous stage
           
            var compress = new Compress(next: null);
            var log = new Logger(next: compress);
            var authenticate = new Authentication(next: log);

            var webServer = new WebServer(pipline: authenticate);
            webServer.Handle(httpRequest);
        }
    }
}
