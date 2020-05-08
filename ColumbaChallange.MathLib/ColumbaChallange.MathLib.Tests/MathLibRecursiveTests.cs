using System;
using Xunit;

namespace ColumbaChallange.MathLib.Tests
{
    public class MathLibRecursiveTests : AbstractMathLibTests
    {
        public MathLibRecursiveTests()
            : base(new MathLibRecursive())
        {
        }
    }
}