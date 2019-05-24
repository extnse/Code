using System;
using static System.Console;

namespace IterationStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string password = string.Empty;
            int x = 0;
            do
            {
                WriteLine("Enter password: ");
                password = ReadLine();
                x++;
            }
            while (password != "1331" & x!=10);
            if (password == "1331") { WriteLine("Correct."); }
            else { WriteLine("Too many incorrect entries."); }
            
            for(int y = 1; y <= 10; y++)
            {
                WriteLine(y);
            }
            
            string[] names = { "Adam J", "Megan R", "Frank P", "Faridah M", "David S" };
            foreach(string n in names)
            {
                WriteLine($"{n} has {n.Length} characters.");
            }
        }
    }
}
