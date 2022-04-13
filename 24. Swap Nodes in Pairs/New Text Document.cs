public class ListNode
{
    public int val;
    public ListNode next;
    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }
}
class Program
{

    public ListNode head;
    public static void Main(string[] args)
    {
        Program p = new Program();
        p.push(1);
        p.push(2);
        p.push(3);
        p.push(4);
        p.SwapPairs();
    }
    public void SwapPairs()
    {
        ListNode temp = head;
        while (temp != null && temp.next != null)
        {
            int k = temp.val;
            temp.val = temp.next.val;
            temp.next.val = k;
            temp = temp.next.next;
        }

    }

    void push(int new_data)
    {
        ListNode new_node = new ListNode(new_data);
        new_node.next = head;
        head = new_node;
    }
}