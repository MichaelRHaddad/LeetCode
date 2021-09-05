namespace LeetCode.Problems.Problem14_LongestCommonPrefix
{
    partial class Problem14
    {
        /**
         * Accepted by LeetCode.
         * Solves problem 14 faster than 97.21% of C# submissions.
         * Memory usage better than 97.16% of C# subissions.
         **/
        private string Solution1(string[] strs)
        {
            string prefix = string.Empty;
            for (int i = 0; i < strs[0].Length; i++)
            {
                char currentChar = strs[0][i];
                bool lastIteration = false;

                for (int j = 1; j < strs.Length; j++)
                {
                    if(strs[j] == string.Empty || strs[j][i] != currentChar)
                    {
                        return prefix;
                    }

                    // if we reached the end of one of the strings,
                    // then we are done.
                    if(i + 1 == strs[j].Length)
                    {
                        lastIteration = true;
                    }
                }

                prefix += currentChar;

                if(lastIteration)
                {
                    return prefix;
                }
            }

            return prefix;
        }
    }
}