namespace LeetCode.Problems.Problem9_PalindromeNumber
{
    partial class Problem9
    {
        /**
         * Accepted by LeetCode.
         * Solves problem 9 faster then 38.17% of C# submissions.
         * Memory usage better than 35.49% of C# subissions.
         **/
        private bool Solution1(int x)
        {
            if (x < 0) return false;

            string number = x.ToString();
            for(int i = 0; i < number.Length / 2; i++)
            {
                if(number[i] != number[number.Length - 1 - i])
                {
                    return false;
                }
            }

            return true;
        }
    }
}
