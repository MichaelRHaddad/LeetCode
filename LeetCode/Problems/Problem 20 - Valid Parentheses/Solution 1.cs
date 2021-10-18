using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Problems.Problem20_ValidParentheses
{
    partial class Problem20
    {
        /**
         * Accepted by LeetCode.
         * Solves problem 20 faster than 88.6% of C# submissions.
         * Memory usage better than 7.51% of C# subissions.
         **/
        private bool Solution1(string s)
        {
            if (s.Length % 2 == 1) return false;

            var dict = new Dictionary<char, char>()
            {
                { '(',')' },
                { '[',']' },
                { '{','}' }
            };
            var stack = new Stack<char>();

            foreach (char c in s)
            {
                if (c == '(' || c == '[' || c == '{')
                {
                    stack.Push(c);
                }
                else if (stack.Count > 0 && c == dict[stack.Peek()])
                {
                    stack.Pop();
                }
                else
                {
                    return false;
                }
            }
            return stack.Count == 0;
        }
    }
}