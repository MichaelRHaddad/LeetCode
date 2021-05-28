using System;

namespace LeetCode.Problems.Problem7_ReverseInteger
{
    class Problem7
    {
        public int Reverse(int x)
        {
            int y = Math.Abs(x);
            if (y < 10)
            {
                return x;
            }

            int lastDigit = y % 10;
            int yLength = (int)Math.Log10(y);
            int nextDigitsReversed = Reverse(y / 10);
            int absoluteResult = lastDigit * (int)Math.Pow(10, yLength) + nextDigitsReversed;

            if (x != y)
            {
                absoluteResult *= -1;
            }
            
            return absoluteResult;
        }
    }
}
