namespace StrategyPattern
{
    public class JpegCompress : IComprese
    {
        public void CompreseImage()
        {
            System.Console.WriteLine("compressing Image to JPEG");
        }
    }
}