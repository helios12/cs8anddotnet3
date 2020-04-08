using System;

using static System.Console;

namespace CheckingForOverflow
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                checked
                {
                    int x = int.MaxValue - 1;
                    WriteLine($"Initial value: {x}");
                    x++;
                    WriteLine($"After incrementing: {x}");
                    x++;
                    WriteLine($"After incrementing: {x}");
                    x++;
                    WriteLine($"After incrementing: {x}");
                }
            }
            catch (OverflowException)
            {
                WriteLine("The code overflowed, but we caught the exception.");
            }

            unchecked
            {
                int y = int.MaxValue + 1;
                WriteLine($"Initial value: {y}");
                y--;
                WriteLine($"After decrementing: {y}");
                y--;
                WriteLine($"After decrementing: {y}");
            }
            
            checked
            {
                int max = 500;
                for (byte i = 0; i < max; i++)
                {
                    WriteLine(i);
                }
            }
        }
    }
}
