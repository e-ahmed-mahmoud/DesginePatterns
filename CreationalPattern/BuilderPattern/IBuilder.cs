using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPattern
{
    public interface IBuilder
    {
        void BuildStepA();
        void BuildStepB();

        void BuildStepC();

        void Reset();

    }
}
