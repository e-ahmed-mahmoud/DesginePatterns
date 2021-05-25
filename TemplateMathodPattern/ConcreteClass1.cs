using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMathodPattern
{
    public class ConcreteClass1 : TaskContext
    {
        public ConcreteClass1( RecorderCommanBehaviour recorder ):base (recorder)
        {

        }
        protected override void DoExecute()
        {
            Console.WriteLine("Execute Task A");
        }
    }
}
