using System;
using System.Linq;

namespace ColumbaChallange.MathLib
{
    public class MathLibV2 : IMathLib
    {
        public long Factorial(int n)
        {
            throw new NotImplementedException();
            //return Enumerable.Range(0, n).Aggregate((i, j) => i*j);
        }
    }
}
