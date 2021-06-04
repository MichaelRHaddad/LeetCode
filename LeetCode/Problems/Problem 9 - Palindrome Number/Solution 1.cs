namespace LeetCode.Problems.Problem9_PalindromeNumber
{
    partial class Problem9
    {
        private bool Solution1(int x)
        {
            string number = x.ToString();
            for(int i = 0; i < number.Length / 2; i++)
            {
                if(number[i] != number[number.Length - i])
                {
                    return false;
                }
            }

            return true;
        }
    }
}
