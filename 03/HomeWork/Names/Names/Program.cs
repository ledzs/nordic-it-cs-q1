using System;

namespace Names
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] names = new string[3];
            byte[] ages = new byte[3];
            for (int i = 0; i <= 2; i++ )
            {
                Console.WriteLine($"Enter name {i+1}");
                names[i] = Console.ReadLine();
                Console.WriteLine($"Enter {names[i]}'s age");
                ages[i] = byte.Parse(Console.ReadLine());
            }
            for (int i = 0; i <= 2; i++)
            {
                Console.WriteLine($"Name: {names[i]}, age in 4 years: {ages[i]+4}");
                
            }
            Console.WriteLine("Press any key to complete");
            Console.ReadKey();
        }
    }
}
