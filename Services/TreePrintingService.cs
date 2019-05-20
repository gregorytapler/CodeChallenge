using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenge.Services
{
    internal class TreePrintingService
    {
        internal StringBuilder PrintedTree { get; set; }

        internal TreePrintingService()
        {
            PrintedTree = new StringBuilder();
        }

        internal void PrintTree(List<TreeNode> treeNodes, string level, bool isSorted = false)
        {
            var nodes = isSorted ? treeNodes.OrderBy(o => o.Value).ToList() : treeNodes;
            foreach (var node in nodes)
            {
                if (node.Value.Length > 0)
                {
                    PrintedTree.Append($"{level} {node.Value}");
                    PrintedTree.AppendLine();
                }
                PrintTree(node.ChildNodes, $"{level}-", isSorted);
            }
        }
    }
}
