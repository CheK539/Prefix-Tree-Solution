using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prefix_Tree_Solution
{
    public static class Program
    {
        public static void Main()
        {
            var prefixTree = new PrefixTree();
            prefixTree.Add("blab");
            prefixTree.Add("blin");
            var queue = new Queue<char>();
            queue.Enqueue('c');
            queue.Enqueue('d');
        }
    }
}