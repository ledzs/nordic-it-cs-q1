using System;
namespace HW13
{
    public class ConsoleLogWriter : ILogWritter
    {
        //***********Singleton pattern************
        private static ConsoleLogWriter instance;

        private ConsoleLogWriter()
        { }
        public static ConsoleLogWriter GetInstance()
        {
            return instance ?? (instance = new ConsoleLogWriter());
        }
        //***********Singleton pattern************

        public void LogError(string message)
        {
            string messageType = "Error";
            Console.WriteLine($"\n{DateTime.Now.ToString("yyyy-MM-ddTHH:mm:sszzz")}\t{messageType}\t{message}");
        }

        public void LogInfo(string message)
        {
            string messageType = "Info";
            Console.WriteLine($"\n{DateTime.Now.ToString("yyyy-MM-ddTHH:mm:sszzz")}\t{messageType}\t{message}");
        }

        public void LogWarning(string message)
        {
            string messageType = "Warning";
            Console.WriteLine($"\n{DateTime.Now.ToString("yyyy-MM-ddTHH:mm:sszzz")}\t{messageType}\t{message}");
        }
    }
}
