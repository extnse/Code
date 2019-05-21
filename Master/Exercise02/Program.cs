using System;
using static System.Console;

namespace Master
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] types = {"sbyte", "byte", "short", "ushort", "int", "uint", "long", "ulong", "float", "double", "decimal"};
            int[] size = {sizeof(sbyte), sizeof(byte), sizeof(short), sizeof(ushort), sizeof(int), sizeof(uint), sizeof(long), sizeof(ulong), sizeof(float), sizeof(double), sizeof(decimal)};
            double[] minval = {}; 
            double[] maxval = {}; 
            WriteLine(types);
        }
    }
}
