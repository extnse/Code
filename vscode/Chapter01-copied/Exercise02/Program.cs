using System;
using static System.Console;

namespace Exercise02
{
    class Program
    {
        static void Main()
        {
            string[] types = {"sbyte", "byte", "short", "ushort", "int", "uint", "long",
                "ulong", "float", "double"};
            int[] size = {sizeof(sbyte), sizeof(byte), sizeof(short), sizeof(ushort), sizeof(int), sizeof(uint),
                sizeof(long), sizeof(ulong), sizeof(float), sizeof(double)};
            double[] minval = {sbyte.MinValue, byte.MinValue, short.MinValue, ushort.MinValue, int.MinValue,
            uint.MinValue, long.MinValue, ulong.MinValue, float.MinValue, double.MinValue};
            double[] maxval = {sbyte.MaxValue, byte.MaxValue, short.MaxValue, ushort.MaxValue, int.MaxValue,
            uint.MaxValue, long.MaxValue, ulong.MaxValue, float.MaxValue, double.MaxValue};
            WriteLine("{0,-8} {1,-2} {2,28} {3,30}", "Type", "Size", "Min", "Max");
            WriteLine();
            for (int i=0; i<types.Length; i++)
                WriteLine("{0,-8} {1,-2} {2,30} {3,30}", types[i], size[i], minval[i], maxval[i]);
            WriteLine("{0,-8} {1,-2} {2,30} {3,30}", "decimal", sizeof(decimal), decimal.MinValue, decimal.MaxValue);
        }
    }
}