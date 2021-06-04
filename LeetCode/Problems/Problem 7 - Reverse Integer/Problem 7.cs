﻿using System;

namespace LeetCode.Problems.Problem7_ReverseInteger
{
    class Problem7
    {
        public int Reverse(int x)
        {
            return Solution1(x);
        }

        // Accepted by LeetCode
        // Solves problem 7 in 40 ms, faster then 81.73% of C# submissions
        private int Solution1(int x)
        {
            int result = 0;
            while (x != 0)
            {
                int lastDigit = x % 10; // Could be negative
                if (lastDigit >= 0 && result > (int.MaxValue - lastDigit) / 10 ||
                    lastDigit <= 0 && result < (int.MinValue - lastDigit) / 10)
                {
                    return 0;
                }

                result = result * 10 + lastDigit;
                x /= 10;
            }

            return result;
        }
    }
}
