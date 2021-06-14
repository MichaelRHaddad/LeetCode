using System;

namespace LeetCode.Problems.Problem9_PalindromeNumber
{
    partial class Problem9
    {
        /**
         * Accepted by LeetCode.
         * Solves problem 9 faster than 96.6% of C# submissions.
         * Memory usage better than 54.93% of C# subissions.
         **/
        private bool Solution2(int x)
        {
            if (x < 0) return false;

            int leadingZeros = 0;
            while (x >= 10 || leadingZeros > 0)
            {
                int orderOfMagnitude = (int)Math.Log10(x);
                int biggestWeight = (int)Math.Pow(10, orderOfMagnitude);
                int firstDigit = leadingZeros == 0 ? x / biggestWeight : 0;
                int lastDigit = x % 10;

                if (firstDigit != lastDigit)
                {
                    return false;
                }

                // Removing first digit
                if (leadingZeros > 0)
                {
                    leadingZeros--;
                }
                else
                {
                    x -= firstDigit * biggestWeight;
                    int newOrderOfMagnitude = (int)Math.Log10(x);
                    leadingZeros = orderOfMagnitude - 1 - newOrderOfMagnitude;
                }

                // Removing last digit
                x /= 10;
            }

            return true;
        }
    }
}
