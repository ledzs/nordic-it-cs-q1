using System;

namespace Figures
{
    [Flags]
    enum Conteiners : int
    {
        None = 0, //0
        One = 0x1,//001
        Five = 0x2,//010
        Twenty = 0x4//100
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Какой объем в литрах требуется упаковать?");
            int litersNeeded = int.Parse(Console.ReadLine());
            int oneLiterConteiner = 1;
            int fiveLiterConteiner = 5;
            int twentyLiterConteiner = 20;
            int remainder; //остаток

            int resultForTwenty = Math.DivRem(litersNeeded, twentyLiterConteiner, out remainder);
            int resultForFive = Math.DivRem(remainder, fiveLiterConteiner, out remainder);
            int resultForOne = Math.DivRem(remainder, oneLiterConteiner, out remainder);
            
            //выставляем все флаги в 0 (None)
            Conteiners oneFlag = Conteiners.None, fiveFlag = Conteiners.None, twentyFlag = Conteiners.None;

            if (resultForOne != 0)
            {
                oneFlag = Conteiners.One;
            }
            if (resultForFive != 0)
            {
                fiveFlag = Conteiners.Five;
            }
            if (resultForTwenty != 0)
            {
                twentyFlag = Conteiners.Twenty;
            }

            string textResult = "Вам потребуются контейнеры в количестве \n";
            if(resultForTwenty != 0)
            {
                textResult = textResult + resultForTwenty + " шт." + " по 20 литров \n";
            }
            if (resultForFive != 0)
            {
                textResult = textResult + resultForFive + " шт." + " по 5 литров \n";
            }
            if (resultForOne != 0)
            {
                textResult = textResult + resultForOne + " шт." + " по 1 литру \n";
            }
            Console.WriteLine(textResult);

            var allowedContainers = oneFlag | fiveFlag | twentyFlag; 
            Console.WriteLine($"Используемые типы контейнеров: {allowedContainers}");

            var allowedContainersInt = (int)allowedContainers;
            Console.WriteLine($"Признак использования типов контейнеров в формате Int32: {allowedContainersInt}");
            var allowedContainersBin = Convert.ToString(allowedContainersInt, 2);
            Console.WriteLine($"Признак использования типов контейнеров в двоичном представлении: {allowedContainersBin}");
            Console.ReadKey();
        }
    }
}