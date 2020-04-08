using System;

using static System.Console;

namespace IterationStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            while (x < 10)
            {
                WriteLine(x);
                x++;
            }
            WriteLine();

            string password = String.Empty;
            int attempts = 0;
            do
            {
                if (attempts < 5)
                {                
                    Write("Enter your password: ");
                    password = ReadLine();
                }
                else
                {
                    WriteLine("You have exceeded the number of attempts.");
                }
                attempts ++;
            }
            while (password != "password" && attempts <= 5);
            if (password == "password")
            {
                WriteLine("Correct.");
            }
            WriteLine();

            for (int y = 1; y <= 10; y++)
            {
                WriteLine(y);
            }
            WriteLine();

            string[] names = { "Adam", "Barry", "Charlie" };
            foreach (string name in names)
            {
                WriteLine($"{name} has {name.Length} characters.");
            }
            WriteLine();
        }
    }
}
