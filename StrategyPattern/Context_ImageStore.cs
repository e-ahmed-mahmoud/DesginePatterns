using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
   public class Context_ImageStore
    {
        /*private string _imageName;
        private readonly IComprese _comprese;
        private readonly IFilter _filter;

        public Context_ImageStore(string name, IComprese comprese, IFilter filter)
        {
            _comprese = comprese;
            _filter = filter;
            _imageName = name;
        }*/
        public void StoreImage(IComprese comprese, IFilter filter)
        {
            filter.FilterImage();
            comprese.CompreseImage();
        }
    }
}
