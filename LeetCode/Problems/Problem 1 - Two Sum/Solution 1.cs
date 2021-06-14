using System;
using System.Collections.Generic;

namespace LeetCode.Problems.Problem1_TwoSum
{
    partial class Problem1
    {
        /**
         * Accepted by LeetCode.
         * Solves problem 1 faster than 93.36% of C# submissions.
         * Memory usage better than 16.21% of C# subissions.
         **/
        private int[] Solution1(int[] nums, int target)
        {
            var numberToIndexMap = new Dictionary<int, ushort>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (numberToIndexMap.ContainsKey(target - nums[i]))
                {
                    return new int[2] { i, numberToIndexMap[target - nums[i]] };
                }

                numberToIndexMap.Add(nums[i], (ushort)i);
            }

            throw new ArgumentException("No Solution");
        }
    }
}
