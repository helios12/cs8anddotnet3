using System;

namespace PrimeFactors
{
    class Program
    {
        static void Main(string[] args)
        {
            PrimeFactorsLib.PrimeFactors primeFactors = new PrimeFactorsLib.PrimeFactors();
            Console.WriteLine(primeFactors.GetPrimeFactorsAsString(102340));
        }
    }
}
