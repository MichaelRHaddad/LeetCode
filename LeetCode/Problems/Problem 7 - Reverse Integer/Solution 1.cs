namespace LeetCode.Problems.Problem7_ReverseInteger
{
    partial class Problem7
    {
        /**
         * Accepted by LeetCode.
         * Solves problem 7 faster than 81.87% of C# submissions.
         * Memory usage better than 82.83% of C# subissions.
         **/
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
