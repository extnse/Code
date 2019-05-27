using System;
using static System.Console;

namespace HandlingExceptions
{
    class Program
    {
        static void Main()
        {
            // Handling certain exceptions
            WriteLine("Before parsing.");
            WriteLine("What is your age?");
            string input = ReadLine();
            try
            {
                int age = int.Parse(input);
                WriteLine($"You are {age} years old.");
            }
            // The order in which to catch exceptions IS important
            catch (OverflowException) // Input is too big or small for current type
            {
                WriteLine("Your age is a valid number format but is either too big or small");
            }
            catch (FormatException) // Format error (text instead of number)
            {
                WriteLine("The age you entered is not a valid number format.");
            }
            catch(Exception ex) // All exceptions
            {
                WriteLine($"{ex.GetType()} - {ex.Message}");
            }
            WriteLine("After parsing.");
        }
    }
}
