using System;
using Xunit;

using PrimeFactorsLib;

namespace PrimeFactorsLibTests
{
    public class PrimeFactorsTests
    {
        [Fact]
        public void Test2()
        {
            string expectedResult = "2";
            string actualResult;
            PrimeFactors primeFactors = new PrimeFactors();
            actualResult = primeFactors.GetPrimeFactorsAsString(2);
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void Test10()
        {
            string expectedResult = "2";
            string actualResult;
            PrimeFactors primeFactors = new PrimeFactors();
            actualResult = primeFactors.GetPrimeFactorsAsString(3);
            Assert.Equal(expectedResult, actualResult);
        }
    }
}
