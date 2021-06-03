using System;

namespace LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {
            var problem = new Problems.Problem7_ReverseInteger.Problem7();

            var solution = problem.Reverse(int.MinValue);
            Console.WriteLine(solution);

            Console.ReadKey();
        }
    }
}
