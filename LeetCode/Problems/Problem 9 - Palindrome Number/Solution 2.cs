using System;

namespace LeetCode.Problems.Problem9_PalindromeNumber
{
    partial class Problem9
    {
        private bool Solution2(int x)
        {
            if (x < 0) return false;

            while (x != 0)
            {
                byte orderOfMagnitude = (byte)Math.Log10(x);
                int biggestWeight = (int)Math.Pow(10, orderOfMagnitude);
                byte firstDigit = (byte)(x / biggestWeight);
                byte lastDigit = (byte)(x % 10);

                if (firstDigit != lastDigit)
                {
                    return false;
                }

                // Removing first digit
                x -= firstDigit * biggestWeight;

                // Removing last digit
                x /= 10;
            }

            return true;
        }
    }
}
