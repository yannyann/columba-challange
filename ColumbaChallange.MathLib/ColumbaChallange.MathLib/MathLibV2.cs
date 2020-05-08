using System;
using System.Linq;

namespace ColumbaChallange.MathLib
{
    public class MathLibV2 : IMathLib
    {
        public long Factorial(int n)
        {
            EnsureNStrictlyPositive(n);
            return n == 0 ? 1 : Enumerable.Range(1, n).Aggregate((i, j) => i * j);
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
