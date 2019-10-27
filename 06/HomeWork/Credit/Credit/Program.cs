using System;

namespace Credit
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введите сумму взноса в рублях");
                float payment = float.Parse(Console.ReadLine());
                Console.WriteLine("Введите ежедневный процент дохода в виде десятичной дроби (1% = 0,01)");
                float percent = float.Parse(Console.ReadLine());
                Console.WriteLine("Введите желаемую сумму накопления");
                float profit = float.Parse(Console.ReadLine());
                uint days = 0;
                if (payment < 0 || percent < 0 || profit < 0)
                {
                    Console.WriteLine("Все значения должны быть больше нуля!");
                }
                else
                {
                    while (payment < profit)
                    {
                        payment = payment * percent + payment;
                        days++;
                    }
                    Console.WriteLine($"Дней понадобится: {days}");
                    Console.ReadKey();
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Введено неправильное значение");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Введено слишком большое значение");
            }
        }
    }
}
