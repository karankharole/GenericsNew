﻿namespace GenericsNew
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int maxNumber = GenericsMax.MaxIntNumber(154, 200, 900);
            Console.WriteLine("\n Maximum Number is " + maxNumber);
        }
    }
}