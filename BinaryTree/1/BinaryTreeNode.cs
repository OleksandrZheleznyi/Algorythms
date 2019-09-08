using System;

namespace BinaryTree
{
    internal class BinaryTreeNode<TNode> : IComparable<TNode> where TNode : IComparable<TNode>
    {
        public TNode Value
        {
            get;
            private set;
        }

        public BinaryTreeNode(TNode value)
        {
            Value = value;
        }

        public BinaryTreeNode<TNode> Left
        {
            get;
            set;
        }

        public BinaryTreeNode<TNode> Right
        {
            get;
            set;
        }

        public int CompareTo(TNode node)
        {
            return Value.CompareTo(node);
        }
    }
}
