using System;

namespace Lab1_Part4_01
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Vui long nhap ten: ");
            var name = Console.ReadLine();
            Console.WriteLine("Please enter address: ");
            var address = Console.ReadLine();
            Console.WriteLine("Please enter phone: ");
            var phone = Console.ReadLine();
            Console.WriteLine("the information you just entered is: ");
            Console.WriteLine($"name: {name}, address: {address}, phone: {phone}");
        }
    }
}