using System;
using LeetCode.Problems.Problem2_AddTwoNumbers;

namespace LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {
            var problem = new Problem2();

            var l1 = new ListNode(2, new ListNode(4, new ListNode(3)));
            var l2 = new ListNode(5, new ListNode(6, new ListNode(4)));

            var result = problem.AddTwoNumbers(l1, l2);

            Console.ReadKey();
        }
    }
}
