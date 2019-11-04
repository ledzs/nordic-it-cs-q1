using System;
namespace HW12
{
    class ChatReminderItem : ReminderItem
    {
        public string ChatName { get; set; }
        public string AccountName { get; set; }

        public ChatReminderItem(DateTimeOffset alarmDate, string alarmMessage, string chatName, string accountName) : base(alarmDate, alarmMessage)
        {
            ChatName = chatName;
            AccountName = accountName;
        }
        public override void WriteProperties(ReminderItem objectType)
        {
            base.WriteProperties(objectType);
            Console.WriteLine(
                $"ChatName: {ChatName},\n" +
                $"AccountName: {AccountName}\n");
            
        }
    }

}