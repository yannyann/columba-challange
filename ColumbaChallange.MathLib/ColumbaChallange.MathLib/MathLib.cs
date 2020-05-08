using System;

namespace ColumbaChallange.MathLib
{
    public class MathLib : IMathLib
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



        private void EnsureNStrictlyPositive(int n)
        {
            if (n < 0)
            {
                throw new ArgumentException($"{nameof(n)} cannot be strictly negative.");
            }
        }
    }
}
