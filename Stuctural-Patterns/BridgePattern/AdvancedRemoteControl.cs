using System;
using System.Collections.Generic;
using System.Text;

namespace BridgePattern
{
    public class AdvancedRemoteControl : RemoteControl
    {
        public AdvancedRemoteControl(Device device) : base(device)
        {
        }

        public void SetChannel(int channelNumber)
        {
            device.SetChannel(channelNumber);
        }
    }
}
