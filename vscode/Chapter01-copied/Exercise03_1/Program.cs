using System;
using static System.Console;

namespace Exercise03_1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                checked
                {
                int max = 310;
                var answer = string.Empty;

                for(byte i = 0; i<max; i++)
                { 
                    if(max>byte.MaxValue)
                    {
                        do
                        {
                            WriteLine("Warning: Possible overflow. Continue anyway? y/n");
                            answer = ReadLine();
                        }
                        while (answer != "y" & answer != "n");
                        if(answer == "y")
                        {
                            for(byte j = 0; j<max; j++)
                            { 
                                WriteLine(j); 
                            }
                        }
                        else
                            break;
                    }
                    else
                    {
                        WriteLine(i); 
                    }
                } //end for
                } // end checked
                
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