using System;

namespace ColumbaChallange.MathLib
{
    public class MathLib : IMathLib
    {
        private IMathLib _mathLib;

        public MathLib(IMathLib mathLib)
        {
            _mathLib = mathLib;
        }

        public static MathLib CreateMathLib(MathLibType type)
        {
            IMathLib mathLibImpl;
            switch (type)
            {
                case MathLibType.Recursive:
                    mathLibImpl = new MathLibRecursive();
                    break;
                case MathLibType.ListFunction:
                    mathLibImpl = new MathLibListFunction();
                    break;
                default:
                    throw new ArgumentException($"The type {type} is not supported.");
            }

            return new MathLib(mathLibImpl);
        }

        public Type MathLibImplType => _mathLib.GetType();

        public long Factorial(int n)
        {
            return _mathLib.Factorial(n);
        }

        public long SquareFactorial(int n)
        {
            return _mathLib.SquareFactorial(n);
        }

        public long UnevenFactorial(int n)
        {
            return _mathLib.UnevenFactorial(n);
        }
    }
}