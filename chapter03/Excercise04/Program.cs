using System;

using static System.Console;

namespace Excercise04
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10 & 8;
            WriteLine(x);
            return;

            Write("Input number 1 between 0 and 255: ");
            string input1 = ReadLine();

            Write("Input number 2 between 0 and 255: ");
            string input2 = ReadLine();

            try
            {
                byte number1 = byte.Parse(input1);
                byte number2 = byte.Parse(input2);

                int result = number1 / number2;
                WriteLine($"{number1} devided by {number2} is {result}");
            }
            catch (OverflowException)
            {
                WriteLine("Overflow happened.");
            }
            catch (FormatException)
            {
                WriteLine("Number is provided in a wrong format.");
            }
            catch (DivideByZeroException)
            {
                WriteLine("You tried to devide by zero.");
            }
        }
    }
}
