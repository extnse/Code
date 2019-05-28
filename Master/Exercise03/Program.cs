using System;
using static System.Console;

namespace Exercise03
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                checked
                {
                int max = 300;
                var answer = string.Empty;
                if(max>byte.MaxValue)
                { 
                    do
                    {
                        WriteLine("Warning: Possible overflow. Continue anyway? y/n");
                        answer = ReadLine();
                    }
                    while (answer != "y");
                }
                for(byte i = 0; i<max; i++)
                { WriteLine(i); }
                }
            }
            catch(OverflowException)
            {
                WriteLine("Type overflow exception.");
            }
            catch(Exception ex)
            {
                WriteLine($"{ex.GetType()} - {ex.Message}");
            }
            // END
        }
    }
}
