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
            // convert null to 0
            int node1ValueAsNumber = (l1?.val) ?? 0;
            int node2ValueAsNumber = (l2?.val) ?? 0;

            int value = (node1ValueAsNumber + node2ValueAsNumber + carry) % 10;
            int nextCarry = (node1ValueAsNumber + node2ValueAsNumber) / 10;

            if (nextCarry == 0 && l1?.next == null && l2?.next == null)
            {
                return new ListNode(value, null);
            }
            else
            {
                return new ListNode(value, AddTwoNumbers(l1?.next, l2?.next, nextCarry));
            }


            /*if (l1.next == null)
            {
                next = l2.next;
            }
            if (l2.next == null)
            {
                next = l1.next;
            }*/

        }
    }
}