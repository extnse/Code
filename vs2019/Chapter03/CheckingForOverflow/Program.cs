using System;
using static System.Console;

namespace CheckingForOverflow
{
    class Program
    {
        static void Main()
        {
            // Instruction 'checked'
            try
            {
                checked
                {
                    var x = int.MaxValue - 1;
                    WriteLine($"intMaxVal - 1 = {x}");
                    x++;
                    WriteLine($"intMaxVal   =   {x}");
                    x++;
                    WriteLine($"intMaxVal + 1 = {x}");
                    x++;
                    WriteLine($"intMaxVal + 2 = {x}");
                }
            }
            catch(OverflowException)
            {
                WriteLine("Overflow, but caught the exception.");
            } 

            // Instruction 'unchecked'
            unchecked
            {
                int y = int.MaxValue + 1;
                WriteLine($"intMaxVal + 1 = {y} (overflow)"); // outputs -2147...8
                y--;
                WriteLine($"intMaxVal   =   {y}"); // outputs 2147...7
                y--;
                WriteLine($"intMaxVal - 1 = {y}"); // outputs 2147...6
            }
        }
    }
}
