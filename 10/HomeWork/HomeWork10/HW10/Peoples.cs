using System;

namespace HomeWork10
{
    public class Peoples
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int AgeAfter4Year
        {
            get
            {
                return Age + 4;
            }
        }
        public string Result
        {
            get
            {
                return $"Имя: {Name}, возраст через 4 года составит: {AgeAfter4Year}.";
            }
        }

    }
}
