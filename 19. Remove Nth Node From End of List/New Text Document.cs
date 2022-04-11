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
    public ListNode RemoveNthFromEnd(ListNode head, int n)
    {
        ListNode first = head;
        ListNode second = head;
        for (int i = 0; i < n; i++)
        {
            if (second.next == null)
            {
                if (i == n - 1)
                    head = head.next;
                return head;
            }
            second = second.next;
        }
        while (second.next != null)
        {
            first = first.next;
            second = second.next;
        }
        first.next = first.next.next;
        return head;
    }
}