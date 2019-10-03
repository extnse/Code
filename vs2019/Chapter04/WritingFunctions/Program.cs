using System;
using static System.Console;

namespace WritingFunctions
{
    class Program
    {
        
        // Functions' launcher
        static void Main(string[] args)
        {
            //RunTimesTable();
            //RunSalesTax();
            //RunCardinalToOrdinal();
            RunFactorial();
        }

        
        // Multiply Table
        static void TimesTable(byte number)
        {
            WriteLine($"This is the {number} times table");
            for (int row = 1; row <= 10; row++)
            {
                WriteLine($"{row} x {number} = {row * number}");
            }
        }
        static void RunTimesTable()
        {
            Write("Enter a number between 0 and 255: ");
            if (byte.TryParse(ReadLine(), out byte number))
            {
                TimesTable(number);
            }
            else
            {
                WriteLine("You did not enter a valid number!");
            }
        }

        
        // Function returning value
        static decimal SalesTax(decimal sum, string rcode)
        {
            WriteLine(sum);
            WriteLine(rcode);
            decimal rate = 0.0M;
            switch(rcode)
            {
                case "CH": // Switzerland
                    rate = 0.08M;
                    break;
                case "DK": // Denmark
                case "NO": // Norway
                    rate = 0.25M;
                    break;
                case "GB": // Great Britain
                case "FR": // France
                    rate = 0.2M;
                    break;
                case "HU": // Hungary
                    rate = 0.27M;
                    break;
                case "OR": // Oregon
                case "AK": // Alaska
                case "MT": // Montana
                    rate = 0.0M;
                    break;
                case "ND": // North Dakota
                case "WI": // Wisсonsin
                case "ME": // Maryland
                case "VA": // Virginia
                    rate = 0.05M;
                    break;
                case "CA": // California
                    rate = 0.0825M;
                    break;
                default: // Most US states
                    rate = 0.06M;
                    break;
            }
            return sum * rate;
        }
        static void RunSalesTax()
        {
            Write("Enter an amount: ");
            string amountInText = ReadLine();
            Write("Enter a region code in two capital letters: ");
            string region = ReadLine();
            if (decimal.TryParse(amountInText, out decimal amountInNumber))
            {
                decimal taxToPay = SalesTax(amountInNumber, region);
                WriteLine($"You must pay {taxToPay} in sales tax.");
            }
            else
            {
                WriteLine("You did not enter a valid amount!");
            }
        }

        
        // Formatting input numbers
        static string CardinalToOrdinal(int number)
        {
            switch(number)
            {
                case 11:
                case 12:
                case 13:
                    return $"{number}th";
                default:
                    string numberAsText = number.ToString();
                    char lastDigit = numberAsText[numberAsText.Length - 1];
                    string suffix = String.Empty;
                    switch(lastDigit)
                    {
                        case '1':
                            suffix = "st";
                            break;
                        case '2':
                            suffix = "nd";
                            break;
                        case '3':
                            suffix = "rd";
                            break;
                        default:
                            suffix = "th";
                            break;
                    }
                    return $"{number}{suffix}";
            }
        }
        static void RunCardinalToOrdinal()
        {
            for(int number = 1; number <=30; number++)
            {
                Write($"{CardinalToOrdinal(number)} ");
            }
        }

        
        // Factorial using recursion
        static decimal Factorial(decimal number)
        {
            if(number < 1)
            {
                return 0;
            }
            else if (number == 1)
            {
                return 1;
            }
            else
            {
                return number * Factorial(number - 1);
            }
        }
        static void RunFactorial()
        {
            try
            {
                checked
                {
                    Write("Enter a number: ");
                    if (int.TryParse(ReadLine(), out int number))
                    {
                        WriteLine($"{number:N0}! = {Factorial(number):N0}");
                        WriteLine($"MV = {decimal.MaxValue:N0}");
                    }
                    else
                    {
                        WriteLine("You did not enter a valid number!");
                    }
                }
            }
            catch
            {
                WriteLine("Number too large.");
            }
        }
    }
}
