namespace LeetCode.Problems.Problem2_AddTwoNumbers
{
    partial class Problem2
    {
        /**
         * Accepted by LeetCode.
         * Solves problem 2 faster than 92.64% of C# submissions.
         * Memory usage better than 80.32% of C# subissions.
         **/
        private ListNode Solution1(ListNode l1, ListNode l2)
        {
            return AddTwoNumbers(l1, l2, 0);
        }

        private ListNode AddTwoNumbers(ListNode l1, ListNode l2, int carry)
        {
            // convert null to 0
            int node1ValueAsNumber = (l1?.val) ?? 0;
            int node2ValueAsNumber = (l2?.val) ?? 0;

            int sum = node1ValueAsNumber + node2ValueAsNumber + carry;
            int value =  sum % 10;
            int nextCarry = sum / 10;

            if (nextCarry == 0 && l1?.next == null && l2?.next == null)
            {
                return new ListNode(value, null);
            }
            else
            {
                return new ListNode(value, AddTwoNumbers(l1?.next, l2?.next, nextCarry));
            }
        }
    }
}