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
            var problem = new Problems.Problem7_ReverseInteger.Problem7();

            var solution = problem.Reverse(int.MinValue);
            Console.WriteLine(solution);

            Console.ReadKey();
        }
    }
}
