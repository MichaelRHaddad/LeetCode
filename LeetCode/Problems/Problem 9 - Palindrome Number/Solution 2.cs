using System;

namespace LeetCode.Problems.Problem9_PalindromeNumber
{
    partial class Problem9
    {
        private bool Solution2(int x)
        {
            if (x < 0) return false;

            byte leadingZeros = 0;
            while (x >= 10 || leadingZeros > 0)
            {
                // ()100121001
                // (00)12100
                // (0)1210
                // ()121
                // ()2

                byte orderOfMagnitude = (byte)Math.Log10(x);
                // 8
                // 4
                // 3
                // 2
                // 0

                int biggestWeight = (int)Math.Pow(10, orderOfMagnitude);
                // 100000000
                // 10000
                // 1000
                // 100
                // 1

                byte firstDigit = leadingZeros == 0 ? (byte)(x / biggestWeight) : (byte)0;
                // 1
                // 0
                // 0
                // 1
                // 2

                byte lastDigit = (byte)(x % 10);
                // 1
                // 0
                // 0
                // 1
                // 2

                if (firstDigit != lastDigit)
                {
                    return false;
                }

                // Removing first digit
                if (leadingZeros > 0)
                {
                    leadingZeros--;
                    // (0)12100
                    // ()1210
                }
                else
                {
                    x -= firstDigit * biggestWeight;
                    // ()121001
                    // ()21
                    // ()0

                    byte newOrderOfMagnitude = (byte)Math.Log10(x);
                    // 5
                    // 1

                    leadingZeros = (byte)(orderOfMagnitude - 1 - newOrderOfMagnitude);
                    // 2
                    // 0
                }

                // Removing last digit
                x /= 10;
                // (00)12100
                // (0)1210
                // ()121
                // ()2
            }

            return true;
        }
    }
}
