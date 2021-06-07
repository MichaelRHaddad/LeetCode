using System;

namespace LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {
            var problem = new Problems.Problem9_PalindromeNumber.Problem9();

            Console.WriteLine(problem.IsPalindrome(121));
            Console.WriteLine(problem.IsPalindrome(-121));
            Console.WriteLine(problem.IsPalindrome(10));
            Console.WriteLine(problem.IsPalindrome(-101));
            Console.WriteLine(problem.IsPalindrome(6547456));
            Console.WriteLine(problem.IsPalindrome(654456));
            Console.WriteLine(problem.IsPalindrome(1000021));

            Console.ReadKey();
        }
    }
}
