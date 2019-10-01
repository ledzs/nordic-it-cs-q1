using System;

namespace ConsoleApp2
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Введите возраст");
			var ages = int.Parse(Console.ReadLine());
			var firstDigit = ages / 10;
			var ostatok = ages % 10;

			switch (ostatok)
			{
				case 1 when firstDigit > 1 || firstDigit == 0:
					Console.WriteLine($"Возраст {ages} год");
					break;
				case 2 when firstDigit > 1 || firstDigit == 0:
					Console.WriteLine($"Возраст {ages} года");
					break;
				case 3 when firstDigit > 1 || firstDigit == 0:
					Console.WriteLine($"Возраст {ages} года");
					break;
				case 4 when firstDigit > 1 || firstDigit == 0:
					Console.WriteLine($"Возраст {ages} года");
					break;
				case 5 when firstDigit > 1 || firstDigit == 0:
					Console.WriteLine($"Возраст {ages} лет");
					break;
				case 6 when firstDigit > 1 || firstDigit == 0:
					Console.WriteLine($"Возраст {ages} лет");
					break;
				case 7 when firstDigit > 1 || firstDigit == 0:
					Console.WriteLine($"Возраст {ages} лет");
					break;
				case 8 when firstDigit > 1 || firstDigit == 0:
					Console.WriteLine($"Возраст {ages} лет");
					break;
				case 9 when firstDigit > 1 || firstDigit == 0:
					Console.WriteLine($"Возраст {ages} лет");
					break;
				case 0 when firstDigit > 1 || firstDigit == 0:
					Console.WriteLine($"Возраст {ages} лет");
					break;
				default:
					Console.WriteLine($"{ages} лет");
					break;
			}
			Console.ReadLine();
		}
	}
}
