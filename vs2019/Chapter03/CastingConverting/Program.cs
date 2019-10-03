using System;
using static System.Console;
using static System.Convert;

namespace CastingConverting
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int a = 10;
            double b = a; //int can be stored as double
            WriteLine(b);

            double c = 9.8;
            int d = (int)c;
            WriteLine(d);

            long e = 10;
            int f = (int)e;
            WriteLine($"e is {e} and f is {f}");
            e = long.MaxValue;
            f = (int)e;
            WriteLine($"e is {e} and f is {f}");

            double g = 9.2;
            int h = (int)g;
            WriteLine($"g is {g}, h is {h}");

            double i = 9.49;
            double j = 8.5;
            double k = 10.49;
            double l = 11.5;
            WriteLine($"i is {i}, ToInt(i) is {ToInt32(i)}");
            WriteLine($"j is {j}, ToInt(j) is {ToInt32(j)}");
            WriteLine($"k is {k}, ToInt(k) is {ToInt32(k)}");
            WriteLine($"l is {l}, ToInt(l) is {ToInt32(l)}"); 

            var number = 12;
            WriteLine(number.ToString());
            var boolean = true;
            WriteLine(boolean.ToString());
            var now = DateTime.Now;
            WriteLine(now.ToString());
            var me = new object();
            WriteLine(me.ToString()); 

            //Convert binary object to string
            //declare 128-bit array
            byte[] binaryObject = new byte[128]; //analogy: var binaryObject
            //fill the array with random bytes
            (new Random()).NextBytes(binaryObject);
            WriteLine("Binary object as bytes:");
            for (int index = 0; index < binaryObject.Length; index++)
            {
                Write($"{binaryObject[index]:X} ");
            }
            WriteLine();
            //convert to Base64
            string encoded = Convert.ToBase64String(binaryObject);
            WriteLine($"Binary Object as Base64String: {encoded}"); 

            //Convert string to integer/datetime:
            // using Parse
            int age = int.Parse("38"); // Also possible to use var age
            DateTime birthday = DateTime.Parse("4 July 1980");
            WriteLine($"I was born {age} years ago.");
            WriteLine($"My birthday is {birthday}.");
            WriteLine($"My birthday is {birthday:D}."); 
            // using TryParse
            Write("How many things are there? ");
            int count;
            string input = Console.ReadLine();
            if(int.TryParse(input, out count))
            {
                WriteLine($"There are {count} things.");
            }
            else
            {
                WriteLine($"Unable to parse...");
            } 
        }
    }
}
