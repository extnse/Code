using System;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            object height = 1.88; // store double as object
            object name = "Amir"; // store string as object
            //int length1 = name.Length; // compilation error!
            int length2 = ((string)name).Length; // privedenie dlya dostupa k chlenam
            dynamic anotherName = "Ahmed"; // store string as dynamic
            int length = anotherName.Length; // compiling with possible exceptions
            Console.WriteLine($"{height}, NAME length is {length2} symbols, NAME2 length is {length}");
        }
    }
}
