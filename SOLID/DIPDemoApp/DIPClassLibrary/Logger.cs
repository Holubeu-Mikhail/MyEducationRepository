using System;

namespace DIPClassLibrary
{
    public class Logger
    {
        public void Log(string message)
        {
            Console.WriteLine($"Write to console: {message}");
        }
    }
}