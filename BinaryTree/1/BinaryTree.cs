using System;
using System.Collections;
using System.Collections.Generic;

namespace BinaryTree
{
    internal class BinaryTree<T> : IEnumerable<T> where T : IComparable<T>
    {
        private BinaryTreeNode<T> _head;

        private int _count;

        public BinaryTreeNode<T> Head
        {
            get
            {
                return _head;
            }
        }

        public int Count
        {
            get
            {
                return _count;
            }
        }

        public void Add(T value)
        {
            if (_head == null)
            {
                _head = new BinaryTreeNode<T>(value);
            }
            else
            {
                AddTo(_head, value);
            }

            _count++;
        }

        private void AddTo(BinaryTreeNode<T> node, T value)
        {
            if (value.CompareTo(node.Value) < 0)
            {
                if (node.Left == null)
                {
                    node.Left = new BinaryTreeNode<T>(value);
                }
                else
                {            
                    AddTo(node.Left, value);
                }
            }
            else
            {
                if (node.Right == null)
                {
                    node.Right = new BinaryTreeNode<T>(value);
                }
                else
                {
                    AddTo(node.Right, value);
                }
            }
        }

        public void ShowPreOrder(BinaryTreeNode<T> root)
        {
            if (root != null)
            {
                Console.Write("{0} ",root.Value);
                ShowInOrder(root.Left);
                ShowInOrder(root.Right); 
            }
        }

        public void ShowPostOrder(BinaryTreeNode<T> root)
        {
            if (root != null)
            {
                ShowInOrder(root.Left);
                ShowInOrder(root.Right);
                Console.Write("{0} ", root.Value);
            }
        }

        public void ShowInOrder(BinaryTreeNode<T> root)
        {
            if (root != null)
            {
                ShowInOrder(root.Left);
                Console.Write("{0} ", root.Value);
                ShowInOrder(root.Right);
            } 
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
