using System;
using System.Collections.Generic;
using System.Text;

namespace BridgePattern
{
    public class RemoteControl
    {
        protected readonly Device device;

        public RemoteControl(Device device)
        {
            this.device = device;
        }

        public void TurnOn()
        {
            device.TurnOn();
        }

        public void TurnOff()
        {
            device.TurnOff();
        }


    }
}
