using System;
using System.IO;
using static System.Console;

namespace SelectionStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            object o = 3;
            int j = 4;
            if(o is int i)
            {
                WriteLine($"{i} x {j} = {i*j}");
            }
            else
            {
                WriteLine("o is not an INT, so it cannot multiply.");
            }

            A_label:
            var number = (new Random()).Next(1, 7);
            WriteLine($"My random number is {number}");
            switch (number)
            {
                case 1:
                    WriteLine("One");
                    break;
                case 2:
                    WriteLine("Two");
                    goto case 1;
                case 3:
                case 4:
                    WriteLine("Three or four");
                    goto case 1;
                case 5:
                    //two seconds sleep
                    WriteLine("Error. Trying again.");
                    System.Threading.Thread.Sleep(2000);
                    goto A_label;
                default:
                    WriteLine("default");
                    break;
            } //end switch

            string path = @"C:\Users\User\Code\vs2019\Chapter03";
            Stream s = File.Open(
                Path.Combine(path, "file.txt"),
                FileMode.OpenOrCreate);
            switch(s)
            {
                case FileStream writeableFile when s.CanWrite:
                    WriteLine("the stream is to a writeable file.");
                    break;
                case FileStream readOnlyFile:
                    WriteLine("The stream is to a read-only file.");
                    break;
                case MemoryStream ms:
                    WriteLine("the stream is to a memory address.");
                    break;
                default: //checked last, no matter the positon
                    WriteLine("the stream is some other type.");
                    break;
                case null:
                    WriteLine("The stream is null.");
                    break;
            }
        }
    }
}
