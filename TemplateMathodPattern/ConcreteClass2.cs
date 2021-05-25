using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMathodPattern
{
    public class ConcreteClass2 : TaskContext
    {
        public ConcreteClass2(RecorderCommanBehaviour recorder):base (recorder)
        {

        }
        protected override void DoExecute()
        {
            Console.WriteLine("Execute Task B");
        }

        
        protected override void ExecuteTest() 
        {
            base.ExecuteTest();
            Console.WriteLine("Execute Test Derived B");
        }
    }
}
