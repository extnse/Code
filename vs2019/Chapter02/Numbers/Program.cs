using System;

namespace Numbers
{
    class Program
    {
#pragma warning disable IDE0060 // Remove unused parameter
        private static void Main()
#pragma warning restore IDE0060 // Remove unused parameter
        {
            Console.WriteLine($"int uses {sizeof(int)} bytes and can store numbers in the range {int.MinValue:N0} to {int.MaxValue:N0}.");
            Console.WriteLine($"double uses {sizeof(double)} bytes and can store numbers in the range {double.MinValue:N0} to {double.MaxValue:N0}.");
            Console.WriteLine($"decimal uses {sizeof(decimal)} bytes and can store numbers in the range {decimal.MinValue:N0} to {decimal.MaxValue:N0}.");
            decimal a = 0.1M;
            decimal b = 0.2M;
            if (a+b==0.3M)
            {
                Console.WriteLine($"{a} + {b} equals 0.3");
            }
            else
            {
                Console.WriteLine($"{a} + {b} does not equal 0.3");
            }
        }
    }
}
