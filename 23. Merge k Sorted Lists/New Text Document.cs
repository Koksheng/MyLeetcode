public ListNode head;
public static void Main(string[] args)
{
    Program p = new Program();
    ListNode[] arr = new ListNode[3];

    arr[0] = new ListNode(1);
    arr[0].next = new ListNode(3);
    arr[0].next.next = new ListNode(5);
    arr[0].next.next.next = new ListNode(7);

    arr[1] = new ListNode(2);
    arr[1].next = new ListNode(4);
    arr[1].next.next = new ListNode(6);
    arr[1].next.next.next = new ListNode(8);

    arr[2] = new ListNode(0);
    arr[2].next = new ListNode(9);
    arr[2].next.next = new ListNode(10);
    arr[2].next.next.next = new ListNode(11);

    ListNode result = p.MergeKList(arr);

}
public ListNode MergeKList(ListNode[] lists)
{
    List<int> retlist = new List<int>();

    foreach (ListNode ln in lists)
    {
        ListNode cycler = ln;
        while (cycler != null)
        {
            retlist.Add(cycler.val);
            cycler = cycler.next;
        }
    }

    retlist.Sort();
    retlist.Reverse();

    ListNode n = null;

    foreach (int i in retlist)
    {
        n = new ListNode(i, n);
    }
    return n;

}