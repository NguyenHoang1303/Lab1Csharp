using System;

namespace Lab1_03_2
{
    class ReferenceType
    {
        public int valueVal;
    }

    class TestReference
    {
        public static void Main(string[] args)
        {
            ReferenceType refer = new ReferenceType();
            refer.valueVal = 5;
            Test(refer);
            Console.WriteLine("The value of the variable is {0}",refer.valueVal);
            Console.ReadLine();
        }

        private static void Test(ReferenceType refer)
        {
            var temp = 5;
            refer.valueVal = temp * 2;
        }
    }
}