using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPattern
{
    public class ConcertBuilder2 : IBuilder
    {
        private Product _product = new Product();

        public ConcertBuilder2()
        {
            Reset();
        }
        public void BuildStepA()
        {
            //Console.WriteLine("Build StepA from Builder 2");
            _product.Add((string)("Build StepA from Builder 2"));
        }

        public void BuildStepB()
        {
            //Console.WriteLine("Build StepB from Builder 2");
            _product.Add((string)("Build StepB from Builder 2"));
        }

        public void BuildStepC()
        {
            Console.WriteLine("Build StepC from Builder 2");
            _product.Add((string)("Build StepC from Builder 2"));
        }

        public void Reset()
        {
            Console.WriteLine("Reset Builder 2");
            _product = new Product();
        }

        public Product GetProduct()
        {
            Product product = this._product;
            this.Reset();

            return product;
        }
    }
}
