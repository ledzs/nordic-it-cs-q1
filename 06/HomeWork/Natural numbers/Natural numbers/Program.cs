using System;

namespace Natural_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите положительное натуральное число не более 2 миллиардов");
            while (true)
            {
                try
                {
                    var number = int.Parse(Console.ReadLine());
                    int c = 0;
                    if (number > 0 && number < 2000000000)
                    {
                        while (number != 0)
                        {
                            if ((number % 10) % 2 == 0)
                            {
                                c++;
                            }
                            number = number / 10;
                        }
                        Console.WriteLine("Количество четных цифр: {0}", c);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Введено неверное значение, попробуйте еще раз");
                        continue;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Ошибка! {e.GetType()}, попробуйте еще раз!");
                    continue;
                }
            }
            Console.WriteLine("Нажмите любую клавишу для выхода");
            Console.ReadKey();
            
        }
    }
}
