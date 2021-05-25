using System;

namespace BridgePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" *********** Bridge Pattern *********** ");
            var sonyRemote = new RemoteControl(new SonyConcertDevice());
            var lgRemote = new AdvancedRemoteControl(new LGConcertDevice());
            sonyRemote.TurnOff();
            lgRemote.SetChannel(50);
        }
    }
}
