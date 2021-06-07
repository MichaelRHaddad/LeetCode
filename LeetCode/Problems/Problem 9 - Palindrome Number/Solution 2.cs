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
                byte length = (byte)Math.Log10(x);
                byte firstDigit = (byte)(x / Math.Pow(10, length));
                byte lastDigit = (byte)(x % 10);

                if (firstDigit != lastDigit)
                {
                    return false;
                }

                x -= firstDigit * (int)Math.Pow(10, length); // Removing first digit
                x /= 10; // Removing last digit
            }

            return true;
        }
    }
}
