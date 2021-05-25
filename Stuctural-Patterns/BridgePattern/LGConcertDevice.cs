using System;

namespace BridgePattern
{
    public class LGConcertDevice : Device
    {
        public void SetChannel(int channelNumber)
        {
            Console.WriteLine($"LG Tv Channel Number is : {channelNumber}");
        }

        public void TurnOff()
        {
            Console.WriteLine($"LG Tv is Turned Off");
        }

        public void TurnOn()
        {
            Console.WriteLine($"LG Tv is Turned On");
        }
    }
}