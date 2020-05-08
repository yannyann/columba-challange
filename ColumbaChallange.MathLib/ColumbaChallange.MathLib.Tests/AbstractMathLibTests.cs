using System;
using Xunit;

namespace ColumbaChallange.MathLib.Tests
{
    public abstract class AbstractMathLibTests
    {
        protected readonly IMathLib MathLib;

        public AbstractMathLibTests(IMathLib mathLib)
        {
            MathLib = mathLib;
        }

        [Theory]
        [InlineData(0, 1)]
        [InlineData(1, 1)]
        [InlineData(10, 3628800)]
        public void ShouldCalculateFactorial(int n, int expected)
        {
            var result = MathLib.Factorial(n);

            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(-1)]
        [InlineData(-10)]
        [InlineData(int.MinValue)]
        public void FactorialShouldThrowArgumentExceptionIfNStrictlyNegative(int n)
        {
            Assert.Throws<ArgumentException>(() => MathLib.Factorial(n));

        }


        [Theory]
        //WARNING unevenFactorial(0) has been defined as 1 arbritrary and could evolve in the future.
        [InlineData(0, 1)]
        [InlineData(1, 1)]
        [InlineData(2, 1)]
        [InlineData(3, 3)]
        [InlineData(4, 3)]
        [InlineData(9, 945)]
        [InlineData(10, 945)]
        public void ShouldCalculateUnevenFactorial(int n, int expected)
        {
            var result = MathLib.UnevenFactorial(n);

            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(-1)]
        [InlineData(-10)]
        [InlineData(int.MinValue)]
        public void UnevenFactorialShouldThrowArgumentExceptionIfNStrictlyNegative(int n)
        {
            Assert.Throws<ArgumentException>(() => MathLib.UnevenFactorial(n));

        }
    }
}
