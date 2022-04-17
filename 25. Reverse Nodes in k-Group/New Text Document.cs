/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution
{
    public ListNode ReverseKGroup(ListNode head, int k)
    {
        if (head == null)
            return null;

        int length = 0;
        ListNode n = head;
        while (n != null)
        {
            length++;
            n = n.next;
        }
        if (length < k)
            return head;

        ListNode current = head;
        ListNode prev = null;
        ListNode next = null;
        int count = 0;
        while (count < k && current != null)
        {
            next = current.next;
            current.next = prev;
            prev = current;
            current = next;
            count++;
        }

        if (current != null)
            head.next = ReverseKGroup(current, k);

        return prev;
    }
}