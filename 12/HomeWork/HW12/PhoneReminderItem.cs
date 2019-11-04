using System;
namespace HW12
{
    class PhoneReminderItem : ReminderItem
    {
        public string PhoneNumber { get; set; }

        public PhoneReminderItem (DateTimeOffset alarmDate, string alarmMessage, string phoneNumber) : base (alarmDate, alarmMessage)
        {
            PhoneNumber = phoneNumber;
        }
        public override void WriteProperties(ReminderItem objectType)
        {
            base.WriteProperties(objectType);
            Console.WriteLine(
                $"PhoneNumber: {PhoneNumber},\n");
        }


    }

}