using System;
using static System.Console;

namespace Exercise03_2
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 1; i <= 100; i++)
            {
                if(i % 5 == 0 || i % 3 == 0)
                {
                    if(i % 3 == 0)
                    {
                        WriteLine("%3");
                        continue;
                    }
                    else
                    {
                        WriteLine("%5");
                        continue;
                    }
                }
                WriteLine(i);        
            }
        }           
    }
}
