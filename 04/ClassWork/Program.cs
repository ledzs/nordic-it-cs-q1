using System;

namespace ConsoleApp5
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Введите длину основания пирамиды a");
			double a = double.Parse(Console.ReadLine());
			Console.WriteLine("Введите высоту боковой стороны пирамиды h");
			double h = double.Parse(Console.ReadLine());
			double sideArea = 3 * a * h;
			double fullArea = 3 / 2 * a * (a * Math.Sqrt(3) + 2 * h);
			double fullSize = Math.Pow(a, 2) / 2 * h * Math.Sqrt(3);
			Console.WriteLine($"S(бок) = {sideArea}, S(полн) = {fullArea}, V={fullSize}");
			Console.ReadKey();
		}
	}
}
