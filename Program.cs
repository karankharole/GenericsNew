namespace GenericsNew
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            MaxNumberCheck<int> objint = new MaxNumberCheck<int>(11, 111, 1111, 11111);
            Console.WriteLine("\nMax integer number is: " + objint.MaxMethod());

            MaxNumberCheck<float> objfloat = new MaxNumberCheck<float>(1.2f, 11.4f, 111.7f, 1111.6f);
            Console.WriteLine("\nMax float number is: " + objfloat.MaxMethod());

            MaxNumberCheck<string> objstring = new MaxNumberCheck<string>("Apple", "Peach", "Banana", "Orange");
            Console.WriteLine("\nMax string word is: " + objstring.MaxMethod());
        }
    }
}