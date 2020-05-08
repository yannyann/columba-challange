using Moq;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace ColumbaChallange.MathLib.Tests
{
    public class MathLibTests
    {
        private MathLib _mathLib;

        private Mock<IMathLib> _mathLibImpl;
        public MathLibTests()
        {
            _mathLibImpl = new Mock<IMathLib>();
            _mathLib = new MathLib(_mathLibImpl.Object);
        }

        [Fact]
        public void FactorialShouldCallFactorialMethodFromImplementation()
        {
            var n = 10;
            _mathLib.Factorial(n);
            _mathLibImpl.Verify(m => m.Factorial(n), Times.Once());
        }

        [Fact]
        public void UnevenFactorialShouldCallFactorialMethodFromImplementation()
        {
            var n = 10;
            _mathLib.UnevenFactorial(n);
            _mathLibImpl.Verify(m => m.UnevenFactorial(n), Times.Once());
        }

        [Fact]
        public void SquareFactorialShouldCallFactorialMethodFromImplementation()
        {
            var n = 10;
            _mathLib.SquareFactorial(n);
            _mathLibImpl.Verify(m => m.SquareFactorial(n), Times.Once());
        }
    }
}
