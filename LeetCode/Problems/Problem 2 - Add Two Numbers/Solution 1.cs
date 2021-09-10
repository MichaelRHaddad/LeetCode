namespace LeetCode.Problems.Problem2_AddTwoNumbers
{
    partial class Problem2
    {
        private ListNode Solution1(ListNode l1, ListNode l2)
        {
            return AddTwoNumbers(l1, l2, 0);
        }

        private ListNode AddTwoNumbers(ListNode l1, ListNode l2, int carry)
        {
            int value;
            ListNode next;

            if (l1.next == null)
            {
                next = l2.next;
            }
            if (l2.next == null)
            {
                next = l1.next;
            }

            value = (l1.val + l2.val) % 10;
            next = AddTwoNumbers(l1.next, l2.next, (l1.val + l2.val) / 10);

            return new ListNode(value, next);
        }
    }
}