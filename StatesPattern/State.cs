using System;
using System.Collections.Generic;
using System.Text;

namespace StatesPattern
{
    public interface IState
    {
        //initerface or abstract that has related behaviour among all states

        void MouseUp();

        void MouseDown();
    }
}
