using System.Collections.Generic;

namespace Prefix_Tree_Solution
{
    public class TreeNode
    {
        public char Value;
        public readonly Dictionary<char, TreeNode> Direction = new Dictionary<char, TreeNode>();
        public bool IsRoot;
    }
}