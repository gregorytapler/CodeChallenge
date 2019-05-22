using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeChallenge.Services
{
    /// <summary>
    /// TreeNode class to manage nested items
    /// </summary>
    internal class TreeNode
    {
        internal TreeNode()
        {
            Value = string.Empty;
            ChildNodes = new List<TreeNode>();
        }

        private string _value;

        protected internal TreeNode Parent;
        protected internal List<TreeNode> ChildNodes;
        protected internal string Value
        {
            get
            {
                return _value.Trim();
            }
            set
            {
                _value = value;
            }
        }
    }
}
