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
    public ListNode MergeTwoLists(ListNode l1, ListNode l2)
    {
        ListNode root = new ListNode(0);
        ListNode currNode = root;
        if (l1 == null && l2 == null)
            return null;
        while (l1 != null || l2 != null)
        {
            int value = 0;
            if (l1 == null)
            {
                value = l2.val;
                l2 = l2.next;
            }
            else if (l2 == null)
            {
                value = l1.val;
                l1 = l1.next;
            }
            else if (l1.val < l2.val)
            {
                value = l1.val;
                l1 = l1.next;
            }
            else
            {
                value = l2.val;
                l2 = l2.next;
            }
            //if(currNode==null)
            //    currNode=new ListNode(value);

            currNode.val = value;
            if (l1 != null || l2 != null)
            {
                currNode.next = new ListNode(0);
                currNode = currNode.next;
            }
        }
        return root;
    }
}