using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortAlgorithms.TreeSortings
{
    public class BinaryTreeNode<T>
    {

        public BinaryTreeNode()
        { 
        }

        public BinaryTreeNode(T data)
        {
            Data = data;
        }

        public BinaryTreeNode<T>? LeftNode { get; set; }
        public BinaryTreeNode<T>? RightNode { get; set; }    
        public T Data { get; set; }


    }
}
