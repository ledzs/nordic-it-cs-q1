using System;

namespace CalculatorEasy
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введите первое число. Дробная часть вводится через запятую ");
                double firstNumber = double.Parse(Console.ReadLine()); //сразу переводим в тип double после ввода
                Console.WriteLine("Введите второе число. Дробная часть вводится через запятую ");
                double secondNumber = double.Parse(Console.ReadLine());
                double addition = firstNumber + secondNumber;
                double subtraction = firstNumber - secondNumber;
                double multiplication = firstNumber * secondNumber;

                Console.WriteLine("Результаты вычислений:");
                Console.WriteLine($"{firstNumber} + {secondNumber}  = {addition}");
                Console.WriteLine($"{firstNumber} - {secondNumber}  = {subtraction}");
                Console.WriteLine($"{firstNumber} * {secondNumber}  = {multiplication}");
                Console.ReadKey();
            }
            catch
            {
                Console.WriteLine("Вы ввели не числовое значение, или ввели дробную часть через точку! \n Нажмите Enter");
                Console.ReadKey();
            }

        }
    }
}
