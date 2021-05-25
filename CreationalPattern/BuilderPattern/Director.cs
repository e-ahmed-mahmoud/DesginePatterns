using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPattern
{
    public class Director
    {
        private IBuilder builder;

        public Director(IBuilder builder)
        {
            this.builder = builder;
        }

        public void GetMinProduct()
        {
            builder.BuildStepA();
        }

        public void GetFullProduct()
        {
            builder.BuildStepA();
            builder.BuildStepB();
            builder.BuildStepC();
        }

    }
}
