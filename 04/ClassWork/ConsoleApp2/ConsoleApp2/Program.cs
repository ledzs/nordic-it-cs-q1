using System;

namespace ConsoleApp2
{
	enum Season : int
	{
		Winter = 3,
		Spring = 6,
		Summer = 9,
		Autumn = 12,
	}

	class Program
	{
		
		static void Main(string[] args)
		{
			Season season1 = Season.Spring;
			int seasonNumber1 = (int)season1;
			Season season2 = Season.Autumn;
			int seasonNumber2 = (int)season2;
			Console.WriteLine("{0} is season number {1}", season1, seasonNumber1);
			Console.WriteLine("{0} is season number {1}", season2, seasonNumber2);
			Console.ReadKey();
		}

	}
}
