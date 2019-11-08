using System;
using System.IO;
namespace HW13
{
    partial class Program
    {
        public class MultipleLogWriter : ILogWritter
        {
            private FileLogWriter fileLogWriterObject;
            private ConsoleLogWriter consoleLogWriterObject;

            public MultipleLogWriter(FileLogWriter fileLogWriter, ConsoleLogWriter consoleLogWriter)
            {
                fileLogWriterObject = fileLogWriter;
                consoleLogWriterObject = consoleLogWriter;
            }
            public void LogError(string message)
            {
                fileLogWriterObject.LogError(message);
                consoleLogWriterObject.LogError(message);
            }

            public void LogInfo(string message)
            {
                fileLogWriterObject.LogInfo(message);
                consoleLogWriterObject.LogInfo(message);
            }

            public void LogWarning(string message)
            {
                fileLogWriterObject.LogWarning(message);
                consoleLogWriterObject.LogWarning(message);
            }
        }
    }
}
