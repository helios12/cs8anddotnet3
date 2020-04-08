using System;

using static System.Console;

namespace PrimeFactors
{
    class Program
    {
        static void Main(string[] args)
        {
            PrimeFactorsLib.PrimeFactors primeFactors = new PrimeFactorsLib.PrimeFactors();
            WriteLine(primeFactors.GetPrimeFactorsAsString(102340));
        }
    }
}
