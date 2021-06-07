using System;

namespace LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {
            var problem = new Problems.Problem9_PalindromeNumber.Problem9();

            var solution = problem.IsPalindrome(-101);
            Console.WriteLine(solution);

            Console.ReadKey();
        }
    }
}
