using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeChallenge.Services
{
    public class TreeService
    {
        private string _treeData;

        internal TreeService(string treeData)
        {
            _treeData = treeData;
        }

        internal List<TreeNode> GetTree()
        {
            var nodeParent = new TreeNode { Parent = null, Value = "root", ChildNodes = new List<TreeNode>() };
            var nodeChild = nodeParent;

            //iterate through each char in the string data
            foreach (var c in _treeData)
            {
                switch (c)
                {
                    case '(':
                        nodeChild = new TreeNode { Parent = nodeChild };
                        nodeChild.Parent.ChildNodes.Add(nodeChild);
                        break;
                    case ')':
                        nodeChild = new TreeNode { Parent = nodeChild.Parent?.Parent };
                        nodeChild.Parent?.ChildNodes.Add(nodeChild);
                        break;
                    case ',':
                        if (!string.IsNullOrWhiteSpace(nodeChild.Value))
                        {
                            nodeChild = new TreeNode { Parent = nodeChild.Parent };
                            nodeChild.Parent.ChildNodes.Add(nodeChild);
                        }
                        break;
                    default:
                        nodeChild.Value += c;
                        break;
                }
            }

            return nodeParent.ChildNodes;
        }
    }
}
