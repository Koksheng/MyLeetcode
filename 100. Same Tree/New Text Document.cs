public class TreeNode
{
    public int val;
    public TreeNode left, right;

    public TreeNode(int item)
    {
        val = item;
        left = right = null;
    }
}

public class Solution
{
    public TreeNode root;
    public static void Main(string[] args)
    {
        //Program p = new Program();
        Program tree = new Program();
        tree.root = new TreeNode(1);
        tree.root.left = new TreeNode(2);
        tree.root.right = new TreeNode(3);
        Program tree1 = new Program();
        tree1.root = new TreeNode(1);
        tree1.root.left = new TreeNode(2);
        tree1.root.right = new TreeNode(3);
        bool result = IsSameTree(tree.root, tree1.root);
    }

    public static bool IsSameTree(TreeNode p, TreeNode q)
    {
        if (p == null && q == null) return true;
        if ((p != null && q == null) || (p == null && q != null)) return false;

        if (p.val != q.val) return false;

        return IsSameTree(p.left, q.left) && IsSameTree(p.right, q.right);
    }
}