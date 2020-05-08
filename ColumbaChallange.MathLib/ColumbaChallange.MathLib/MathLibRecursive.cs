using System;

namespace ColumbaChallange.MathLib
{
    public class MathLibRecursive : IMathLib
    {
        public long Factorial(int n)
        {
            EnsureNStrictlyPositive(n);
            if (n == 0)
            {
                return 1;
            }
            return n * Factorial(n - 1);
        }

        public long UnevenFactorial(int n)
        {
            EnsureNStrictlyPositive(n);
            if (n == 0 || n == 1)
            {
                return 1;
            }
            return n % 2 == 0 ? UnevenFactorial(n - 1) : n * UnevenFactorial(n - 2);
        }

        public long SquareFactorial(int n)
        {
            EnsureNStrictlyPositive(n);
            if (n == 0)
            {
                return 1;
            }
            return n * n * SquareFactorial(n - 1);
        }


        private void EnsureNStrictlyPositive(int n)
        {
            if (n < 0)
            {
                throw new ArgumentException($"{nameof(n)} cannot be strictly negative.");
            }
        }
    }
}