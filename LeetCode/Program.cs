using System;

namespace LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {
            var problem = new Problems.Problem14_LongestCommonPrefix.Problem14();

            Console.WriteLine(problem.LongestCommonPrefix(new[] { "abab", "aba", "" }));

            Console.ReadKey();
        }
    }
}
