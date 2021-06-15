using System.Collections.Generic;

namespace LeetCode.Problems.Problem13_RomanToInteger
{
    partial class Problem13
    {
        /**
         * Accepted by LeetCode.
         * Solves problem 13 faster than 98.14% of C# submissions.
         * Memory usage better than 38.77% of C# subissions.
         **/
        private int Solution1(string s)
        {
            var map = new Dictionary<char, int>
            {
                { 'I', 1 },
                { 'V', 5 },
                { 'X', 10 },
                { 'L', 50 },
                { 'C', 100 },
                { 'D', 500 },
                { 'M', 1000 }
            };

            int result = map[s[s.Length - 1]];
            for (int i = s.Length - 2; i >= 0; i--)
            {
                if(map[s[i + 1]] == map[s[i]] * 5 || map[s[i + 1]] == map[s[i]] * 10)
                {
                    result -= map[s[i]];
                }
                else
                {
                    result += map[s[i]];
                }
            }

            return result;
        }
    }
}