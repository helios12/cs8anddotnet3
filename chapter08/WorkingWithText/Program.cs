using System;

using static System.Console;

namespace WorkingWithText
{
    class Program
    {
        static void Main(string[] args)
        {
            string city = "London";
            WriteLine($"{city} is {city.Length} characters long.");
            WriteLine($"First char is {city[0]} and third is {city[2]}.");

            string cities = "Paris,Berlin,Madrid,New York";
            string[] citiesArray = cities.Split(',');
            foreach (string item in citiesArray)
            {
                WriteLine(item);
            }

            string fullName = "Jones, Alan";
            int indexOfTheComma = fullName.IndexOf(',');
            int indexOfTheSpace = fullName.IndexOf(' ');
            string lastName = fullName.Substring(0, indexOfTheComma);
            string firstName = fullName.Substring(indexOfTheSpace + 1);
            WriteLine($"{firstName} {lastName}");

            string company = "Microsoft";
            bool startsWithM = company.StartsWith('M');
            bool containsN = company.Contains("N");
            WriteLine($"Starts with M: {startsWithM}; contains an N: {containsN}.");

            string recombined = string.Join(" => ", citiesArray);
            WriteLine(recombined);

            string fruit = "Apples";
            decimal price = 0.39M;
            DateTime when = DateTime.Today;
            WriteLine($"{fruit} cost {price:C} on {when:dddd}s.");
            WriteLine(string.Format("{0} cost {1:C} on {2:dddd}s.", fruit, price, when));
        }
    }
}
