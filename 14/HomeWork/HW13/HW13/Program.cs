using System;
using System.IO;

namespace HW13
{
    partial class Program
    {
        static void Main(string[] args)
        {
            //****расположение лога меняется в классе FileLogWriter.cs*****

            var logInFile = FileLogWriter.GetInstance();
            var logInConsole = ConsoleLogWriter.GetInstance();


            var multipleLogWriter = new MultipleLogWriter(logInFile, logInConsole);

            multipleLogWriter.LogError("ErrorMessage");
            multipleLogWriter.LogInfo("InfoMessage");
            multipleLogWriter.LogWarning("WarningMessage");

            Console.ReadKey();
        }
    }
}
