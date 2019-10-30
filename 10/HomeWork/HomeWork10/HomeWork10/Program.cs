using System;

namespace HomeWork10
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[3];
            int[] ages = new int[3];
            //string[] peoples = new string[3];
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Введите имя {i+1}-го человека:");
                names[i] = Console.ReadLine();
                Console.WriteLine($"Введите его возраст:");
                ages[i] = int.Parse(Console.ReadLine());
                string p = "peoples{i}";

                Peoples p = new Peoples
                {
                    Name = names[i],
                    Age = ages[i]
                };
            }

            Peoples p1 = new Peoples
            {
                Name = "Ivan",
                Age = 23
            };

            Console.WriteLine(p1.Result);
            Console.ReadKey();
        }
    }
}
