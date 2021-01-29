using System;

namespace Retonex
{
    class Program
    {
        static void Main(string[] args)
        {
            // Change the Apperence
            Console.Title = "Retonex";
            Console.ForegroundColor = ConsoleColor.Red;
            
            Console.WriteLine("")

            string nameU = Console.ReadLine();

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

            Bitmap:
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

            Console.WriteLine("==> Please enter your Retonex password");

            Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Press any key to close the window...");

            Console.ReadKey();
        ;
    }
}