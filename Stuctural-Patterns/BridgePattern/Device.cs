using System;
using System.Collections.Generic;
using System.Text;

namespace BridgePattern
{
    public interface Device
    {
        void TurnOn();
        void TurnOff();
        void SetChannel(int channelNumber);
    }
}
