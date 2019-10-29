using System;

namespace Words_begining_A
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Введите строку минимум из двух слов (на русском языке)");
                    string words = Console.ReadLine();
                    string[] wordsArray = words.Split(' '); //разбиваем введенную строку на массив с разделителем пробел
                    int k = 0; //для счетчика количества слов
                    if (wordsArray.Length >= 2)
                    {
                        for (int i = 0; i < wordsArray.Length; i++)
                        {
                            wordsArray[i] = wordsArray[i].ToLower(); //приводим к нижнему регистру слово, чтобы сравнивать только маленькую букву "а"
                            if (wordsArray[i].StartsWith("а"))
                            {
                                k++;
                            }
                        }
                        Console.WriteLine($"Количество слов, начинающихся с буквы 'А': {k}");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Введите минимум 2 слова!");
                        continue;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine($"Ошибка ввода строки!");
                    continue;
                }
                catch (OverflowException)
                {
                    Console.WriteLine($"Превышен допустимый размер введенной строки!");
                    continue;
                }
            }
            Console.ReadKey();
        }
    }
}
