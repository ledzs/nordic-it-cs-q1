using System;

namespace ConsoleApp1
{
    class Pet
    {
        public string Kind;
        public string Name;
        public char Sex;
        public byte Age;

        public void Display()
        {
            Console.WriteLine($"The pet kind of {Kind}, has name {Name}, age {Age}, sex {Sex}");
            
        }

        public string GetDescription()
        {
            return $"The pet kind of {Kind}, has name {Name}, age {Age}, sex {Sex}";
        }

        public string Description //readonly свойство
        {
            get 
            {
                return $"The pet kind of {Kind}, has name {Name}, age {Age}, sex {Sex}";
            }
        }


    }
}
