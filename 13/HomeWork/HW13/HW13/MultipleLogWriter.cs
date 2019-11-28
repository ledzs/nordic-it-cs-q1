using System;
using System.IO;
namespace HW13
{
    partial class Program
    {
        public class MultipleLogWriter : ILogWritter
        {
            private ILogWritter[] _logWriterObject;
            
            public MultipleLogWriter(params ILogWritter[] logWriterObject)
            {
                _logWriterObject = logWriterObject;
            }
            public void LogError(string message) 
            {
                foreach (ILogWritter objectName in _logWriterObject)
                {
                    objectName.LogError(message);
                }
            }

            public void LogInfo(string message)
            {
                foreach (ILogWritter objectName in _logWriterObject)
                {
                    objectName.LogInfo(message);
                }
            }

            public void LogWarning(string message)
            {
                foreach (ILogWritter objectName in _logWriterObject)
                {
                    objectName.LogWarning(message);
                }
            }
        }
    }
}
