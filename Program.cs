namespace GenericsNew
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double maxFlotingNo = GenericsMax.MaxIntNumber(85.4, 117.6, 119.4);
            Console.WriteLine("\n Maximum floating number for 3rd position is = " + maxFlotingNo);
        }
    }
}