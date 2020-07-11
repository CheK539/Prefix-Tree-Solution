using System.Collections.Generic;
using System.Text;

namespace Prefix_Tree_Solution
{
    public class PrefixTree
    {
        private readonly TreeNode start = new TreeNode();

        public void Add(string word)
        {
            var root = start;
            foreach (var symbol in word)
            {
                if (!root.Direction.ContainsKey(symbol))
                    root.Direction[symbol] = new TreeNode {Value = symbol};

                root = root.Direction[symbol];
            }

            root.IsRoot = true;
        }

        public bool IsContain(string word)
        {
            var root = start;
            foreach (var symbol in word)
            {
                if (root.Direction.ContainsKey(symbol))
                    root = root.Direction[symbol];
                else return false;
            }

            return root.IsRoot;
        }

        public List<string> GetByPrefix(string prefix)
        {
            var root = start;
            foreach (var symbol in prefix)
                root = root.Direction[symbol];
            var result = new List<string>();
            var builder = new StringBuilder();
            builder.Append(prefix.Substring(0, prefix.Length - 1));
            BuildResult(builder, root, result);
            return result;
        }

        private void BuildResult(StringBuilder builder, TreeNode root, List<string> result)
        {
            builder.Append(root.Value);
            if (root.IsRoot)
                result.Add(builder.ToString());
            foreach (var treeNode in root.Direction.Values)
                BuildResult(builder, treeNode, result);
            builder.Remove(builder.Length - 1, 1);
        }
    }
}