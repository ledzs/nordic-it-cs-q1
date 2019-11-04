using System;
using System.Collections.Generic;

namespace HW12
{
    class Program
    {
        static void Main(string[] args)
        {
            var reminderList = new List<ReminderItem>
            {
                new ReminderItem(DateTimeOffset.Parse("2019-10-31 12:3:3"), "Wake UP!"),
                new PhoneReminderItem(DateTimeOffset.Parse("2020-10-31 12:3:3"), "Wake UP!", "8(999)2342323"),
                new ChatReminderItem(DateTimeOffset.Parse("2019-10-31 12:3:3"), "Wake UP!", "WakeUPCHAT", "Ivan1991")
            };

            foreach (ReminderItem i in reminderList)
            {
                i.WriteProperties(i);
            }

            Console.ReadKey();
        }
    }

}