namespace GenericsNew
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string maxString = GenericsTestMax.MaxStringValue("Peach", "Apple", "Banana");
            Console.WriteLine("\n Maximum string value for 1st position is = " + maxString);
        }
    }
}