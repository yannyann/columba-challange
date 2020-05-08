using System;
using Xunit;

namespace ColumbaChallange.MathLib.Tests
{
    public class MathLibTests : AbstractMathLibTests
    {
        public MathLibTests()
            : base(new MathLib())
        {
        }
    }
}
