using System;

namespace HomeWork04
{
    [Flags]
    enum Containers
    {
        TwentyLiters = 1; //001
        FiveLiters = 2;//010
        OneLiters = 4//100
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Какой объем в литрах требуется упаковать?");
            int litersAll = int.Parse(Console.ReadLine());
            
            Containers conteiner
            /*
            int ost;
            int result = Math.DivRem(litersAll, kont20, out ost);
            Console.WriteLine("Количество литров которые упаковать: {0}, Контейнеров 20л надо: {1}, Остаток: {2}", litersAll, result, ost);
            Console.ReadKey();
            */
        }
    }
}