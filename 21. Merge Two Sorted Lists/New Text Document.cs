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
    public ListNode MergeTwoLists(ListNode list1, ListNode list2)
    {
        if (list1 == null && list2 == null)
        {
            return null;
        }
        else if (list1 == null)
        {
            return list2;
        }
        else if (list2 == null)
        {
            return list1;
        }
        ListNode currNode = null;

        if (list2.val < list1.val)
        {
            currNode = list2;
            list2 = list2.next;
        }
        else
        {
            currNode = list1;
            list1 = list1.next;
        }
        ListNode head = currNode;

        while (list1 != null || list2 != null)
        {

            if (list2 == null)
            {
                currNode.next = list1;
                currNode = currNode.next;
                list1 = list1.next;
                continue;
            }
            if (list1 == null)
            {
                currNode.next = list2;
                currNode = currNode.next;
                list2 = list2.next;
                continue;
            }
            if (list1.val < list2.val)
            {
                currNode.next = list1;
                currNode = currNode.next;
                list1 = list1.next;
                continue;
            }
            {
                currNode.next = list2;
                currNode = currNode.next;
                list2 = list2.next;
                continue;
            }
        }
        return head;
    }
}