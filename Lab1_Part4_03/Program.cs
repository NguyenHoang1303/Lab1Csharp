using System;

namespace Lab1_Part4_03
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter 1 to 7:");
            var number = Convert.ToInt32(Console.ReadLine());
            switch (number)
            {
                case 1:
                    Console.WriteLine($"{number}-Monday");
                    break;
                case 2:
                    Console.WriteLine($"{number}-Tuesday");
                    break;
                case 3:
                    Console.WriteLine($"{number}-Wednesday");
                    break;
                case 4:
                    Console.WriteLine($"{number}-Thursday");
                    break;
                case 5:
                    Console.WriteLine($"{number}-Friday");
                    break;
                case 6:
                    Console.WriteLine($"{number}-Saturday");
                    break;
                case 7:
                    Console.WriteLine($"{number}-Sunday");
                    break;
                default:
                    Console.WriteLine("Fail!");
                    break;
            }
        }
    }
}