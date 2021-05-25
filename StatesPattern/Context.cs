using System;
using System.Collections.Generic;
using System.Text;

namespace StatesPattern
{
    public class Context
    {
        //context class that has logic of all operation

        public IState CurrentState { get; set; }

        public void MouseDown()
        {
            CurrentState.MouseDown();
        }
        public void MouseUp()
        {
            CurrentState.MouseUp();
        }

    }
}
