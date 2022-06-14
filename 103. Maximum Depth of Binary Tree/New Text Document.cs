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
        int result = MaxDepth(tree);
    }

    public static int MaxDepth(TreeNode root)
    {
        if (root == null) return 0;
        else
        {
            int leftDepth = MaxDepth(root.left);
            int rightDepth = MaxDepth(root.right);

            if (leftDepth > rightDepth)
                return leftDepth + 1;
            else
                return rightDepth + 1;
        }
    }
}