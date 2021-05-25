using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMathodPattern
{
    public abstract class TaskContext
    {
        private readonly RecorderCommanBehaviour _recorder;

        public TaskContext(RecorderCommanBehaviour recorder)
        {
            _recorder = recorder;
        }

        public void Execute() {
            _recorder.Record();
            DoExecute();
            this.ExecuteTest();
        }
        protected abstract void DoExecute();
        protected virtual void ExecuteTest() {
            Console.WriteLine("Execute Test in Parent");
        }
    }
}
