using System;
using ISPLibrary.Models;
using ISPLibrary.Interfaces;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IBorrowableDVD dvd = new DVD();

            dvd.Borrower = "Mike Black";
            dvd.RuntimeInMinutes = 30;

            Console.ReadLine();
        }
    }
}
