using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace ColumbaChallange.MathLib.Tests
{
    public class MathLibFactoryTests
    {
        private MathLibFactory _mathLibFactory;
        public MathLibFactoryTests()
        {
            _mathLibFactory = new MathLibFactory();
        }

        [Fact]
        public void RecursiveShouldReturnMathLibInstance()
        {
            var mathLib = _mathLibFactory.CreateMathLib(MathLibType.Recursive);
            Assert.IsType<MathLib>(mathLib);
        }
        [Fact]
        public void RecursiveShouldReturnMathLibV2Instance()
        {
            var mathLib = _mathLibFactory.CreateMathLib(MathLibType.ListFunction);
            Assert.IsType<MathLibV2>(mathLib);
        }
    }
}
