using System;
using System.Collections.Generic;
using System.Text;

namespace ColumbaChallange.MathLib
{
    public class MathLibFactory
    {
        public IMathLib CreateMathLib(MathLibType type)
        {
            switch (type)
            {
                case MathLibType.Recursive:
                    return new MathLib();
                case MathLibType.ListFunction:
                    return new MathLibV2();
                default:
                    throw new ArgumentException($"The type {type} is not supported.");
            }
        }
    }
}
