using System;
using static System.Console;

namespace Exercise02
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine($"sbyte {sizeof(sbyte)}, {sbyte.MinValue:N0}, {sbyte.MaxValue:N0} " +
                $"byte {sizeof(byte)}, {byte.MinValue:N0}, {byte.MaxValue:N0} " +
                $"short {sizeof(short)}, {short.MinValue:N0}, {short.MaxValue:N0} " +
                $"ushort {sizeof(ushort)}, {ushort.MinValue:N0}, {ushort.MaxValue:N0} " +
                $"int {sizeof(int)}, {int.MinValue:N0}, {int.MaxValue:N0} " +
                $"uint {sizeof(uint)}, {uint.MinValue:N0}, {uint.MaxValue:N0} " +
                $"long {sizeof(long)}, {long.MinValue:N0}, {long.MaxValue:N0} " +
                $"ulong {sizeof(ulong)}, {ulong.MinValue:N0}, {ulong.MaxValue:N0} " +
                $"float {sizeof(float)}, {float.MinValue:N0}, {float.MaxValue:N0} " +
                $"double {sizeof(double)}, {double.MinValue:N0}, {double.MaxValue:N0} " +
                $"decimal {sizeof(decimal)}, {decimal.MinValue:N0}, {decimal.MaxValue:N0}");
        }
    }
}
