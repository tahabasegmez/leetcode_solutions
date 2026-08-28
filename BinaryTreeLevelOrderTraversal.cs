/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    public IList<IList<int>> LevelOrder(TreeNode root) 
    {
        IList<IList<int>> result = new List<IList<int>>();
        
        if (root == null) return result;

        List<int> levelList = new();

        Queue<TreeNode> queue = new();
        queue.Enqueue(root);

        TreeNode cur = new();

        int size = 0;
        while (queue.Count != 0)
        {
            size = queue.Count;
            for (int i = 0; i < size; i++)
            {
                cur = queue.Dequeue();
                levelList.Add(cur.val);
                if (cur.left != null) queue.Enqueue(cur.left);
                if (cur.right != null) queue.Enqueue(cur.right);
            }

            result.Add(new List<int>(levelList));
            levelList.Clear();
        }
        
        return result;
    }
}