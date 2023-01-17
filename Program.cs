namespace GenericsNew
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string maxString = GenericsTestMax.MaxStringValue( "Apple", "Peach", "Banana");
            Console.WriteLine("\n Maximum string value for 2nd position is = " + maxString);
        }
    }
}