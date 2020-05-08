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
        //https://www.google.com/search?q=factorial+10&rlz=1C1CHBF_frDE882DE882&oq=factorial+10+&aqs=chrome..69i57.6525j0j7&sourceid=chrome&ie=UTF-8
        [InlineData(10, 3628800)]
        public void ShouldCalculateFactorial(int n, int expected)
        {
            var result = MathLib.Factorial(n);

            Assert.Equal(expected, result);
        }
    }
}
