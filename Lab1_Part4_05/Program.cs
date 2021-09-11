using System;
using System.Collections.Generic;

namespace Lab1_Part4_05
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            for (int i = 1; i <= 20; i++)
            {
                List<int> list = new List<int>();
                for (int j = i; j > 0; j--)
                {
                    if (i % j == 0)
                    {
                        list.Add(j);
                    }
                }

                Display(i, list);
            }
        }

        static void Display(int number, List<int> list)
        {
            var result = $"factorials of the {number}: ";
            foreach (var a in list)
            {
                result += Convert.ToString(a) + " ";
            }

            Console.WriteLine(result);
        }
    }
}