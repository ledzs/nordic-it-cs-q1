using System;
using System.IO;

namespace HW13
{
    partial class Program
    {
        static void Main(string[] args)
        {
            var logInFile = FileLogWriter.GetInstance("C:/StudioLog/Log.log");
            var logInConsole = ConsoleLogWriter.GetInstance();

            var multipleLogWriter = new MultipleLogWriter(logInFile, logInConsole);

            multipleLogWriter.LogError("ErrorMessage");
            multipleLogWriter.LogInfo("InfoMessage");
            multipleLogWriter.LogWarning("WarningMessage");

            Console.ReadKey();
        }
    }
}
