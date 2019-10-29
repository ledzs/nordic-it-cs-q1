using System;

namespace HomeWork07_2_
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Введите строку :");
                    string words = Console.ReadLine();

                    if (string.IsNullOrWhiteSpace(words)) //проверяем на пустой ввод
                    {
                        Console.WriteLine("Попробуйте еще раз!");
                        continue;
                    }
                    else
                    {
                        words = words.ToLower();
                        string[] wordsArray = words.Split(); //разбиваем введенную строку на массив
                        for (int i = words.Length - 1; i >= 0; i--) //выводим с последнего элемента до нулевого
                        {
                            Console.Write(words[i]); 
                        }
                        Console.WriteLine();
                        break;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine($"Неправильный формат введенных символов");
                    continue;
                }
                catch (OverflowException)
                {
                    Console.WriteLine($"Превышен допустимый размер введенной строки");
                    continue;
                }
            }
            Console.WriteLine("Нажмите любую клавишу для выхода");
            Console.ReadKey();
        }
    }
}
