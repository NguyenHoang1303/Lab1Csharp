using System;

namespace Lab1_Part4_04
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter number:");
            var number = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i < 9; i++)
            {
                Console.WriteLine($"{number} * {i} = {number * i}");
            }
        }
    }
}