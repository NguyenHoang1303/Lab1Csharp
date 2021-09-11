using System;

namespace Lab3_03_01
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var number = 5;
            Test(number);
            Console.WriteLine("The value of the variable is {0}", number);
            Console.ReadLine();
        }

        static void Test(int number)
        {
            var temp = 5;
            number = temp * 2;
        }
    }
}