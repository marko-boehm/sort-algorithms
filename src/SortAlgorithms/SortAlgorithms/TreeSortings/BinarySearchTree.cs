using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortAlgorithms.TreeSortings
{
    public class BinarySearchTree
    {
        public BinaryTreeNode<int> Root { get; private set; }
        private int _arraySize = 0;
        private int _count = 0;
        private int[] _orderedArray = new int[0];

        public BinarySearchTree()
        {
            Root = new BinaryTreeNode<int>();
        }

        public BinarySearchTree(int data)
        {
            Root = new BinaryTreeNode<int>(data);
        }

        public void AddData(int data)
        {
            AddNode(Root, data);
            _arraySize++;
        }

        public void AddData(int[] data)
        {
            for (int i = 0; i < data.Length; i++)
            {
                AddData(data[i]);
            }
        }

        public int[] InOrder()
        {
            _orderedArray = new int[_arraySize];
            InOrder(Root);
            return _orderedArray;
        }

        public int[] PostOrder()
        {
            throw new NotImplementedException();
        }

        public int[] PreOrder()
        {
            throw new NotImplementedException();
        }

        private void InOrder(BinaryTreeNode<int> node)
        {
            if (node.LeftNode != null)
            {
                InOrder(node.LeftNode);
            }

            _orderedArray[_count] = node.Data;
            _count++;

            if (node.RightNode != null)
            {
                InOrder(node.RightNode);
            }
        }


        private void AddNode(BinaryTreeNode<int> parentNode, int data)
        {
            if (parentNode.Data == 0 && data != 0)
            {
                parentNode.Data = data;
                return;
            }

            if (parentNode.Data == data || data == 0)
            {
                throw new Exception("Integer already exists or not valid!");
            }

            if (parentNode.Data > data)
            {
                if (parentNode.LeftNode == null)
                {
                    parentNode.LeftNode = new BinaryTreeNode<int>(data);
                }
                else
                {
                    AddNode(parentNode.LeftNode, data);
                }
                return;
            }

            if (parentNode.Data < data)
            {
                if (parentNode.RightNode == null)
                {
                    parentNode.RightNode = new BinaryTreeNode<int>(data);
                    return;
                }
                else
                {
                    AddNode(parentNode.RightNode, data);
                }
                return;
            }

        }
    }
}
