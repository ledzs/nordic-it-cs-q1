using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Pet pet1 = new Pet();
            pet1.Name = "The Cat";
            pet1.Kind = "Cat";
            pet1.Sex = 'F';
            pet1.Age = 12;

            Pet pet2 = new Pet() //не нужна ";"
            {
                Name = "The Dog",
                Kind = "Dog",
                Sex = 'M',
                Age = 10
            };

            pet1.Display();
            Console.WriteLine(pet2.GetDescription());
            Console.ReadKey();
        }
        
    }
   
}
