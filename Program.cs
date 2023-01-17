namespace GenericsNew
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string maxString = GenericsTestMax.MaxStringValue( "Apple", "Banana","Peach");
            Console.WriteLine("\n Maximum string value for 3rd position is = " + maxString);
        }
    }
}