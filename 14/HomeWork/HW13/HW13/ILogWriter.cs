using System;
using System.Collections.Generic;
using System.Text;

namespace HW13
{
    public interface ILogWritter
    {
        void LogInfo(string message);
        void LogWarning(string message);
        void LogError(string message);
    }
}
