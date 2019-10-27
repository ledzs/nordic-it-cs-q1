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
                    else if (number < 0 || number == 0)
                    {
                        Console.WriteLine("Число должно быть больше 0");
                        continue;
                    }
                    
                }
                catch (FormatException)
                {
                    Console.WriteLine($"Неправильный формат введенного числа. Введите натуральное положительное число не более 2 млрд.");
                    continue;
                }
                catch (OverflowException)
                {
                    Console.WriteLine($"Превышен допустимый размер введенного числа, введите число меньше 2 млрд");
                    continue;
                }
                catch (Exception e) 
                {
                    Console.WriteLine("Возникло исключение");
                    Console.WriteLine($"{e.GetType()}: {e.Message}"); 
                }
            }
            Console.WriteLine("Нажмите любую клавишу для выхода");
            Console.ReadKey();
            
        }
    }
}
