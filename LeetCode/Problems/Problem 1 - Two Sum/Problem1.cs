using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems.Problem1_TwoSum
{
    class Problem1
    {
        // Accepted by LeetCode
        // Solves problem 1 in 232 ms, faster then 93.36% of C# submissions

        public int[] TwoSum(int[] nums, int target)
        {
            var numberToIndexMap = new Dictionary<int, ushort>();

            for (int i = 0; i < nums.Length; i++)
            {
                if(numberToIndexMap.ContainsKey(target - nums[i]))
                {
                    return new int[2] { i, numberToIndexMap[target - nums[i]] };
                }

                numberToIndexMap.Add(nums[i], (ushort)i);
            }

            throw new ArgumentException("No Solution");
        }
    }
}
