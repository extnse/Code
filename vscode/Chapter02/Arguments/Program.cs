using System;

namespace Arguments
{
    class Program
    {
        static void Main(string[] args)
        {
            var args1 = new string[4];
            args1[0] = "red";
            args1[1] = "yellow";
            args1[2] = "50";
            args1[3] = "10";
            
            Console.ForegroundColor = (ConsoleColor)
                Enum.Parse(typeof(ConsoleColor), args1[0], true);
            Console.BackgroundColor = (ConsoleColor)
                Enum.Parse(typeof(ConsoleColor), args1[1], true);
            try
            {
                Console.WindowWidth = int.Parse(args1[2]);
                Console.WindowHeight = int.Parse(args1[3]);
            }
            catch (PlatformNotSupportedException)
            {
                Console.WriteLine("Cannot resize console windows. Unsupported platform.");
            }
                        
            Console.WriteLine($"There are {args1.Length} arguments.");
            foreach (string arg in args1)
            {
                Console.WriteLine(arg);
            }
        }
    }
}
