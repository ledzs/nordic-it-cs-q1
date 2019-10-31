using System;

namespace HW11
{
    class Program
    {
        static void Main(string[] args)
        {
            var alarm1 = new ReminderItem(
                DateTimeOffset.Parse("2019-10-31 12:3:3"),
                "Wake UP!");
            
            alarm1.WriteProperties();

            var alarm2 = new ReminderItem(
                DateTimeOffset.Parse("2019-10-31 23:15:10"), 
                "Wake UP!");
            
            alarm2.WriteProperties();
            Console.ReadKey();
        }
    }
}