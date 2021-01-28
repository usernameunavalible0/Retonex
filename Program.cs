using System;

namespace Retonex
{
    class Program
    {
        static void Main(string[] args)
        {
            // Change the Apperence
            Console.Title = "Retonex";
            Console.ForegroundColor = ConsoleColor.Black;

            Console.WriteLine("Welcome to Retonex!\nEnter a username bellow");

            string userName = Console.ReadLine();

            Console.WriteLine("Your username is now " + userName + "!");

            Console.WriteLine(userName + " Type Launch when your ready to start the Launcher");

            Console.ReadLine();
            
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Retonex v 1.0.0");
            Console.WriteLine("Loading...");

            Console.ForegroundColor = ConsoleColor.Black;

            Console.WriteLine("Press any key to close the window...");

            Console.ReadKey();
        }
    }
}
