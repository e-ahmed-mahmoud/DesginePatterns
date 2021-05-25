namespace StrategyPattern
{
    public class BlackAndWaitFilter : IFilter
    {
        public void FilterImage()
        {
            System.Console.WriteLine("Apply Balck & White filter on Images");
        }
    }
}