namespace GenericsNew
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Maximum Interger Number is : " + GenericsTestMax.MaxIntNumber<int>(30, 20, 10));
            Console.WriteLine("Maximum Float Number is : " + GenericsTestMax.MaxIntNumber<float>(30.3f, 45.20f, 76.10f));
            Console.WriteLine("Maximum String Number is : " + GenericsTestMax.MaxIntNumber<string>("Peach", "Banana", "apple"));
        }
    }
}