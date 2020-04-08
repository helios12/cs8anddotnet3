using System;
using System.Collections.Generic;

namespace PrimeFactorsLib
{
    public class PrimeFactors
    {
        public int[] GetPrimeFactors(int number)
        {
            List<int> result = new List<int>();
            int currentNumber = number;
            int counter = 2;
            while (currentNumber != 1)
            {
                if (currentNumber % counter == 0)
                {
                    result.Add(counter);
                    currentNumber = currentNumber / counter;
                }
                else
                {
                    counter ++;
                }
            }

            return result.ToArray();
        }

        public string GetPrimeFactorsAsString(int number)
        {
            int[] primeFactors = GetPrimeFactors(number);
            string result = String.Join(", ", primeFactors);

            return result;
        }
    }
}
