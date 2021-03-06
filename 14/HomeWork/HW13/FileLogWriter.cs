﻿using System;
using System.IO;

namespace HW13
{
    public class FileLogWriter : ILogWritter
    {
        //***********Singleton pattern************
        private static FileLogWriter instance;
        string filePath;
        private FileLogWriter(string path)
        { 
            filePath = path;
        }
        public static FileLogWriter GetInstance(string path)
        {
            return instance ?? (instance = new FileLogWriter(path));
        }
        //***********Singleton pattern************

       
        //public FileLogWriter(string path)  
        //{
        //    filePath = path;
        //}
        private void Message(MessageType messageType, string message)
        {
            File.AppendAllText($"{filePath}", $"\n{DateTime.Now.ToString("yyyy-MM-ddTHH:mm:sszzz")}\t{messageType}\t{message}");
        }
        public void LogError(string message)
        {
            MessageType messageType = MessageType.Error;
            Message(messageType, message);
        }

        public void LogInfo(string message)
        {
            MessageType messageType = MessageType.Info;
            Message(messageType, message);
        }

        public void LogWarning(string message)
        {
            MessageType messageType = MessageType.Warning;
            Message(messageType, message);
        }
    }
}
