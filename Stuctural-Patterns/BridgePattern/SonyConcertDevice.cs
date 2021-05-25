using System;
using System.Collections.Generic;
using System.Text;

namespace BridgePattern
{
    public class SonyConcertDevice : Device
    {
        public void SetChannel(int channelNumber)
        {
            Console.WriteLine($"Sony Tv Channel Number is : {channelNumber}");
        }

        public void TurnOff()
        {
            Console.WriteLine($"Sony Tv is Turned Off");
        }

        public void TurnOn()
        {
            Console.WriteLine($"Sony Tv is Turned On");
        }
    }
}
