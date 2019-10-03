using System;

namespace ConsoleApp1
{
    class Program
    {
        [Flags]
        enum MyBit
        {
            V1 = 20,
            V2 = 5,
            V3 = 1,
            
        }

        static void Main(string[] args)
        {
            ShowAllBits();
            Console.ReadKey();
        }
        static void ShowAllBits()
        {
            for (int i = 1; i < 32; i++)
                Console.WriteLine("{0} - {1}", i, (MyBit)i);
        }
    }
}