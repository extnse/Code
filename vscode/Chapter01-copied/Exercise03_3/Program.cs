using System;
using static System.Console;

namespace Exercise03_3
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                WriteLine("DIVISION");
                WriteLine("Enter a number between 0 and 255: ");
                var d1 = Convert.ToByte(ReadLine());
                WriteLine("Enter another number between 0 and 255: ");
                var d2 = Convert.ToByte(ReadLine());
                WriteLine($"{d1} / {d2} = {d1 / d2} (+{d1 % d2})");
            }
            catch(FormatException)
            {
                WriteLine("Exception: Wrong input format. Not a number?");
            }
            catch(OverflowException)
            {
                WriteLine("Exception: Number is out of range.");
            }
            catch(Exception ex)
            {
                WriteLine($"{ex.GetType()} - {ex.Message}");
            }
        }
    }
}
