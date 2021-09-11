using System;
using System.Collections.Generic;

namespace Lab1_Part4_05
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            long result = 1;
            for (int i = 1; i <= 20; i++)
            {
                result *= i;
            }

            Console.WriteLine($"factorials of the integers from 1 to 20: {result}");   
        }
    }
}