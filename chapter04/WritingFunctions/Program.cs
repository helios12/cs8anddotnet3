using System;

using static System.Console;

namespace WritingFunctions
{
    class Program
    {
        static void TimesTable(byte number)
        {
            WriteLine($"This is the {number} times table:");
            for (int row = 1; row <= 12; row++)
            {
                WriteLine($"{row} x {number} = {row * number}");
            }
            WriteLine();
        }

        static void RunTimesTable()
        {
            bool isNumber;
            do
            {
                Write("Enter a number between 0 and 255: ");
                isNumber = byte.TryParse(ReadLine(), out byte number);
                if (isNumber)
                {
                    TimesTable(number);
                }
                else
                {
                    WriteLine("You did not enter a valid number");
                }
            }
            while (isNumber);
        }

        static decimal CalculateTax(decimal amount, string twoLetterRegionCode)
        {
            decimal rate = twoLetterRegionCode.ToUpper() switch
            {
                "CH" => 0.08M,
                "DK" => 0.25M,
                "NO" => 0.25M,
                "GB" => 0.2M,
                "FR" => 0.2M,
                "HU" => 0.27M,
                "OR" => 0.0M,
                "AK" => 0.0M,
                "MT" => 0.0M,
                "ND" => 0.05M,
                "WI" => 0.05M,
                "ME" => 0.05M,
                "VA" => 0.05M,
                "CA" => 0.0825M,
                _ => 0.06M
            };
            return amount * rate;
        }

        static void RunCalculateTax()
        {
            Write("Enter an amount: ");
            string amountInText = ReadLine();
            Write("Enter a two digig region code: ");
            string region = ReadLine();
            if (decimal.TryParse(amountInText, out decimal amount))
            {
                decimal taxToPay = CalculateTax(amount, region);
                WriteLine($"You must pay {taxToPay} VAT.");
            }
            else
            {
                WriteLine("You did not enter a valid amount.");
            }
        }

        /// <summary>
        /// Pass a 32-bit integer and it will be converted into its ordinal equivalent.
        /// </summary>
        /// <param name="number">Number is a cardinal value, e.g. 1, 2, 3 and so on.</param>
        /// <returns>Number as an ordinal vlue, e.g. 1st, 2nd, 3rd and so on.</returns>
        static string CardinalToOrdinal(int number)
        {
            switch (number)
            {
                case 11:
                case 12:
                case 13:
                return $"{number}th";
                break;
                default:
                string numberAsText = number.ToString();
                char lastDigit = numberAsText[numberAsText.Length - 1];
                string suffix = String.Empty;
                switch (lastDigit)
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
            for (int number = 1; number <= 40; number++)
            {
                Write($"{CardinalToOrdinal(number)} ");
            }
            WriteLine();
        }

        static long Factorial(int number)
        {
            if (number < 1)
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
            bool isNumber;
            do
            {
                Write("Enter a number: ");
                isNumber = int.TryParse(ReadLine(), out int number);
                if (isNumber)
                {
                    WriteLine($"{number:N0}! = {Factorial(number):N0}");
                }
                else
                {
                    WriteLine("You did not enter a valid number!");
                }
            }
            while (isNumber);
        }

        static void Main(string[] args)
        {
            // RunTimesTable();
            // RunCalculateTax();
            // RunCardinalToOrdinal();
            RunFactorial();
        }
    }
}
