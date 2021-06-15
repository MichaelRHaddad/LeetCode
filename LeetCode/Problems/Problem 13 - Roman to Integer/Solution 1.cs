using System.Collections.Generic;

namespace LeetCode.Problems.Problem13_RomanToInteger
{
    partial class Problem13
    {
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

            int result = s[s.Length - 1];
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