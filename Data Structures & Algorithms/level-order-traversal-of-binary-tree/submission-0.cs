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
    public List<List<int>> LevelOrder(TreeNode root) {
        // BFS
        var res = new List<List<int>>();

        if(root is null)
            return res;

        var q = new Queue<TreeNode>();
        q.Enqueue(root);

        while(q.Count > 0)
        {
            int qLen = q.Count;
            var level = new List<int>();

            for(int i = 0; i < qLen; i++)
            {
                var node = q.Dequeue();
                level.Add(node.val);

                if(node.left is not null)
                    q.Enqueue(node.left);
                
                if(node.right is not null)
                    q.Enqueue(node.right);
            }
            
            res.Add(level);
        }

        return res;
    }
}
