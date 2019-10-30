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
                return $"Name: {Name}, Age in 4 years: {AgeAfter4Year}.";
            }
        }

    }
}
