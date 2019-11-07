using System;
using System.IO;

namespace HW13
{
    partial class Program
    {
        static void Main(string[] args)
        {
            var logInFile = new FileLogWriter();
            var logInConsole = new ConsoleLogWriter();

            var multipleLogWriter = new MultipleLogWriter(logInFile, logInConsole);

            multipleLogWriter.LogError("ErrorMessage");
            multipleLogWriter.LogInfo("InfoMessage");
            multipleLogWriter.LogWarning("WarningMessage");

            Console.ReadKey();
        }
    }
}
