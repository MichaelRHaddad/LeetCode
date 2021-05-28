using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {
            var problem = new Problems.Problem1_TwoSum.Problem1();

            var solution = problem.TwoSum(new int[] { 2, 7, 11, 15 }, 9);
            Console.WriteLine($"[{solution[0]}, {solution[1]}]");
        }
    }
}
