﻿using System;

namespace Retonex
{
    class Program
    {
        static void Main(string[] args)
        {
            // Change the Apperence
            Console.Title = "Retonex";
            Console.ForegroundColor = ConsoleColor.Red;
            
            string password;
            int ctr = 0;
            int admin = 0;

            Console.WriteLine("Welcome to ℝ𝕖𝕥𝕠𝕟𝕖𝕩\nPlease Enter a username...");
            string nameU = Console.ReadLine();
        
            if(nameU != "Admin") {
            admin++;
            goto Prgstrt;
            }

            Console.WriteLine("Your username is now " + nameU + "!");

            Console.WriteLine(nameU + " Type Launch when your ready to start the Launcher");

            Console.ReadLine();

            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Retonex v1.0.0");
            Console.WriteLine("Loading...");
            Console.WriteLine("Done!");

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("ℝ𝕖𝕥𝕠𝕟𝕖𝕩");

            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("==> Downloading Bitmaps...");
            Console.WriteLine("==> 1%");

            System.Threading.Thread.Sleep(3000);

            Console.WriteLine("==> 21%");

            System.Threading.Thread.Sleep(5000);

            Console.WriteLine("==> 56%");

            System.Threading.Thread.Sleep(1000);

            Console.WriteLine("==> 67%");

            System.Threading.Thread.Sleep(3000);

            Console.WriteLine("==> 84%");

            System.Threading.Thread.Sleep(3000);

            Console.WriteLine("==> 99%");

            System.Threading.Thread.Sleep(8000);

            Console.WriteLine("==> 100%");

            System.Threading.Thread.Sleep(6000);

            Prgstrt:
        do
        {
            Console.WriteLine("==> Please enter your Retonex password");
            password = Console.ReadLine();

            if(password != "admin")
            ctr++;
            else
            ctr=1;

        }
        while((password != "admin1") && (ctr != 3));

            if (ctr == 3) {
                Console.WriteLine("Login attempt three or more times. Try later!");
                goto End;
            } else {
                Console.WriteLine("The password entered successfully!");
                System.Threading.Thread.Sleep(1000);
                goto Long;
            }
            Long:
            {
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Red;

            System.Threading.Thread.Sleep(2000);

            Console.WriteLine("ℝ𝕖𝕥𝕠𝕟𝕖𝕩");
            }

            End:
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Press any key to close the window...");

            Console.ReadKey();
        }
    }
}