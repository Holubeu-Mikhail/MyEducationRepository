using System;
using DIPClassLibrary.Interfaces;

namespace DIPClassLibrary
{
    public class Logger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine($"Write to console: {message}");
        }
    }
}