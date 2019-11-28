using System;
namespace HW13
{
    public class ConsoleLogWriter : ILogWritter
    {
        
        private void Message(MessageType messageType, string message)
        {
            Console.WriteLine($"\n{DateTime.Now.ToString("yyyy-MM-ddTHH:mm:sszzz")}\t{messageType}\t{message}");
        }
        public void LogError(string message)
        {
            MessageType messageType = (MessageType)1;
            Message(messageType, message);
        }
        public void LogInfo(string message)
        {
            MessageType messageType = (MessageType)2;
            Message(messageType, message);
        }
        public void LogWarning(string message)
        {
            MessageType messageType = (MessageType)3;
            Message(messageType, message);
        }
    }
}
