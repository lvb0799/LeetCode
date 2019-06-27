/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution
{
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        ListNode root = new ListNode(-1);
        ListNode cur = root;
        int overTen = 0;
        int addDigit = 0;
        while (l1 != null || l2 != null)
        {
            if (l1 == null)
            {
                addDigit = l2.val + overTen;
                l2 = l2.next;
            }
            else if (l2 == null)
            {
                addDigit = l1.val + overTen;
                l1 = l1.next;
            }
            else
            {
                addDigit = l1.val + l2.val + overTen;
                l1 = l1.next;
                l2 = l2.next;

            }
            if (addDigit >= 10)
            {
                overTen = 1;
                addDigit %= 10;
            }
            else
                overTen = 0;
            if (cur != null)
            {
                cur.next = new ListNode(addDigit);
                cur = cur.next;
            }
        }
        if (overTen == 1)
        {
            cur.next = new ListNode(overTen);
            //cur=cur.next;
        }

        return root.next;
    }
}