using System;

namespace HomeWork10
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[3];
            int[] ages = new int[3];
            Peoples[] peoplesObj = new Peoples[3];

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Введите имя {i + 1}-го человека:");
                names[i] = Console.ReadLine();
                Console.WriteLine($"Введите его возраст:");
                ages[i] = int.Parse(Console.ReadLine());
                peoplesObj[i] = new Peoples
                {
                    Name = names[i],
                    Age = ages[i]
                };
            }
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(peoplesObj[i].Result);
            }
            Console.WriteLine("Нажмите любую клавишу для продолжения...");
            Console.ReadKey();
        }
    }
}

