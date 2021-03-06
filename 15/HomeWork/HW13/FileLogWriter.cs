﻿using System;
using System.IO;

namespace HW13
{
    public class FileLogWriter : ILogWritter
    {
        string path = "C:/StudioLog/Log.log"; //расположение лога
        public void LogError(string message)
        {
            string messageType = "Error";
            File.AppendAllText($"{path}", $"\n{DateTime.Now.ToString("yyyy-MM-ddTHH:mm:sszzz")}\t{messageType}\t{message}");
        }

        public void LogInfo(string message)
        {
            string messageType = "Info";
            File.AppendAllText($"{path}", $"\n{DateTime.Now.ToString("yyyy-MM-ddTHH:mm:sszzz")}\t{messageType}\t{message}");
        }

        public void LogWarning(string message)
        {
            string messageType = "Warning";
            File.AppendAllText($"{path}", $"\n{DateTime.Now.ToString("yyyy-MM-ddTHH:mm:sszzz")}\t{messageType}\t{message}");
        }
    }
}
