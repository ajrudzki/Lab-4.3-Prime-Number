using System;
using Xunit;

namespace Lab_4._3_Prime_Numbers.Test
{
    public class PrimeNumbersTests
    {
        [Theory]
        [InlineData(2, 3)]
        [InlineData(13, 41)]
        [InlineData(14, 43)]
        [InlineData(24, 89)]
        [InlineData(29, 109)]

        public void Test1(int userInput, int expected)
        {
            PrimeNumbers pnum = new PrimeNumbers();
            int res = PrimeNumbers.GetPrime(userInput);
            Assert.Equal(expected, res);
        }
    }
}
