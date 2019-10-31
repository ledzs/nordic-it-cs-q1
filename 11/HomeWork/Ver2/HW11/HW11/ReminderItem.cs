using System;
namespace HW11
{
    class ReminderItem
    {
        
        public DateTimeOffset AlarmDate { get; set; }
        public string AlarmMessage { get; set; }
        public TimeSpan TimeToAlarm
        {
            get { return DateTime.Now - AlarmDate; }
        }

        public bool IsOutdated
        {
            get
            {
                if (TimeToAlarm.TotalSeconds >= 0)
                {
                    return true;
                }
                return false;
            }
        }
        public ReminderItem(DateTimeOffset alarmDate, string alarmMessage)
        {
            AlarmDate = alarmDate;
            AlarmMessage = alarmMessage;
        }
        public void WriteProperties()
        {
            Console.WriteLine(
                $"AlarmDate: {AlarmDate},\n" +
                $"AlarmMessage: {AlarmMessage},\n" +
                $"TimeToAlarm: {TimeToAlarm},\n" +
                $"IsOutdated: {IsOutdated}\n");
        }
    }
}