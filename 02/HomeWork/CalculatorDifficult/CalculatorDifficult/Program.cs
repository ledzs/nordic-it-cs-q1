using System;

namespace CalculatorDifficult
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введите первое число. Дробная часть вводится через запятую ");
                double firstNumber = double.Parse(Console.ReadLine()); //сразу переводим в тип double после ввода, т.к. ReadLine возвращает тип string
                Console.WriteLine("Введите второе число. Дробная часть вводится через запятую ");
                double secondNumber = double.Parse(Console.ReadLine());
                
                //предлагаем ввести число от 1 до 6, от чего зависит выполняемое действие (деление, умножение и т.д.)
                Console.WriteLine(
                    "Выберите действие с числами (Введите одно из чисел от 1 до 6 и нажмите Enter): \n" +
                    "1) Сложение \n" +
                    "2) Вычитание \n" +
                    "3) Умножение \n" +
                    "4) Деление \n" +
                    "5) Остаток от деления \n" +
                    "6) Возведение первого числа в степень второго числа");

                byte operations = byte.Parse(Console.ReadLine()); //выбран тип byte потому что значений может быть всего 6, в целях экономии памяти
                if (operations == 1) //сложение
                {
                    double result = firstNumber + secondNumber;
                    Console.WriteLine($"{firstNumber} + {secondNumber} = {result}");
                }
                else if (operations == 2) //вычитание
                {
                    double result = firstNumber - secondNumber;
                    Console.WriteLine($"{firstNumber} - {secondNumber} = {result}");
                }
                else if (operations == 3) //умножение
                {
                    double result = firstNumber * secondNumber;
                    Console.WriteLine($"{firstNumber} * {secondNumber} = {result}");
                }
                else if (operations == 4) //деление
                {
                    if (secondNumber == 0)//обработка ввода нулевого значения
                    {
                        Console.WriteLine("Деление на ноль!");
                    }
                    else
                    {
                        double result = firstNumber / secondNumber;
                        Console.WriteLine($"{firstNumber} / {secondNumber} = {result}");
                    }
                }
                else if (operations == 5) //остаток от деления
                {
                    if (secondNumber == 0)//обработка ввода нулевого значения
                    {
                        Console.WriteLine("Деление на ноль!");
                    }
                    else
                    {
                        double result = firstNumber % secondNumber;
                        Console.WriteLine($"Остаток от деления {firstNumber} на {secondNumber} = {result}");
                    }
                }
                else if (operations == 6) //возведение первого числа в стпень второго, через метод Math.Pow
                {
                    double result = Math.Pow(firstNumber, secondNumber);
                    Console.WriteLine($"{firstNumber} в степени {secondNumber} = {result}");
                }
                
                else //обработка исключения для выбора арифметического действия
                {
                    Console.WriteLine("Вы не ввели значение от 1 до 6. Нажмите Enter");
                }
                Console.ReadKey();
            }
            catch //обработка исключения только для ввода первого или второго числа
            {
                Console.WriteLine("Вы ввели не числовое значение, или ввели дробную часть через точку! \n Нажмите Enter");
                Console.ReadKey();
            }

        }
    }
}