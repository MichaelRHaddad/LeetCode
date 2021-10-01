using System;
using LeetCode.Problems.Problem2_AddTwoNumbers;

namespace LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {
            var problem = new Problem2();

            var l1 = new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9))));
            var l2 = new ListNode(9);

            var result = problem.AddTwoNumbers(l1, l2);

            Console.ReadKey();
        }
    }
}
