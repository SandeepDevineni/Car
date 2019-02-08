using System;
using Xunit;

namespace UnitTests
{
    public class UnitTest1
    {
        [Fact]
        public void CurrencyConvertor_withvalues()
        {
            var expected = 120;
            var dollar = 100;
            var actual = CurrencyConvertor(dollar);
            Assert.Equal(expected, actual);
        }

                public double CurrencyConvertor(Double dollar)
        {
            return dollar * 1.2;
        }

        [Theory]
        [InlineData(4, 2, 2)]
        [InlineData(10, 5, 2)]
        [InlineData(0, 0, 0)]
        public void Multiply_WorksWithManyInputs(int a, int b, int c)
        {
            Assert.Equal(a, Multiply(b, c));
        }

        int Multiply(int x, int y)
        {
            return x * y;
        }
    }
}
