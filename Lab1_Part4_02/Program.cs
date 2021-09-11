using System;
using System.Collections.Generic;
using System.Xml.Schema;

namespace Lab1_Part4_02
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("please enter number 1:");
            int a = Console.Read();
            Console.WriteLine("please enter number 2:");
            var b = Console.Read();
            Console.WriteLine("please enter number 3:");
            var c = Console.Read();
            
            var max = a;
            if (b > max)
            {
                max = b;
            }
            if (c > max)
            {
                max = c;
            }

            Console.WriteLine($"Max: {max}");
        }
    }
}