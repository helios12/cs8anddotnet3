using System;
using static System.Console;

namespace BitwiseAndShiftOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 6;

            WriteLine($"a = {a}");
            WriteLine($"b = {b}");
            WriteLine($"a & b = {a & b}");
            WriteLine($"a | b = {a | b}");
            WriteLine($"a ^ b = {a ^ b}");
            WriteLine();

            WriteLine($"a << 3 = {a << 3}");
            WriteLine($"b >> 1 = {b >> 1}");
            WriteLine();

            int age = 47;
            char firstDigit = age.ToString()[0];
            WriteLine(firstDigit);
        }
    }
}
