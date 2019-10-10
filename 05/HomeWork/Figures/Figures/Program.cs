using System;

namespace Figures
{
    [Flags]
    enum Figures
    {
        Circle = 1,
        Triangle = 2,
        Rectangle = 3
    }
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine($"Выберите фигуру, которую необходимо посчитать (введите число): \n " +
                    $"Круг - {(int)Figures.Circle}, Треугольник (равносторонний) - {(int)Figures.Triangle}, Прямоугольник - {(int)Figures.Rectangle}");
                Figures result = (Figures)int.Parse(Console.ReadLine());
                if (result == Figures.Circle || result == Figures.Rectangle || result == Figures.Triangle)
                {
                    switch (result)
                    {
                        case Figures.Circle:
                            Console.WriteLine("Введите диаметр:");
                            var diameter = double.Parse(Console.ReadLine());
                            if (diameter > 0)
                            {
                                double area = Math.Round(Math.PI * Math.Pow(diameter, 2) / 4, 3);//считаем площадь через диаметр и округляем до 3-х знаков после запятой для читаемости
                                double circleLenght = Math.Round(2 * Math.PI * diameter / 2, 3);
                                Console.WriteLine($"Площадь круга: {area}, длина круга: {circleLenght}");
                            }
                            else
                            {
                                Console.WriteLine("Значение должно быть только положительным!");
                            }
                            break;

                        case Figures.Triangle:
                            Console.WriteLine("Введите длину стороны:");
                            var triangleLenght = double.Parse(Console.ReadLine());
                            if (triangleLenght > 0)
                            {
                                var triangleArea = Math.Round(Math.Pow(triangleLenght, 2) * Math.Sqrt(3) / 4, 3);
                                var trianglePerimeter = Math.Round(triangleLenght * 3, 3);
                                Console.WriteLine($"Площадь треугольника: {triangleArea}, периметр треугольника: {trianglePerimeter}");
                            }
                            else
                            {
                                Console.WriteLine("Значение должно быть только положительным!");
                            }
                            break;

                        case Figures.Rectangle:
                            Console.WriteLine("Введите ширину прямоугольника:");
                            var rectangleWidth = double.Parse(Console.ReadLine());
                            Console.WriteLine("Введите высоту прямоугольника:");
                            var rectangleHeight = double.Parse(Console.ReadLine());
                            if (rectangleWidth > 0 && rectangleHeight > 0)
                            {
                                var rectangleArea = Math.Round(rectangleWidth * rectangleHeight, 3);
                                var rectanglePerimeter = Math.Round(2 * (rectangleHeight + rectangleWidth), 3);
                                Console.WriteLine($"Площадь прямоугольника: {rectangleArea}, периметр прямоугольника: {rectanglePerimeter}");
                            }
                            else
                            {
                                Console.WriteLine("Значение должно быть только положительным!");
                            }
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Введено неправильное значение!");//для выбора типа фигуры
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Can't continue calculation:");
                Console.WriteLine($"{e.GetType()}: {e.Message}");
            }
            Console.ReadKey();
        }
    }
}
