using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortAlgorithms.TreeSortings
{
    /// <summary>
    /// Wiki: https://en.wikipedia.org/wiki/Bubble_sort
    /// </summary>
    public class BinaryTreeSorting : ISort
    {
        public int[] Sort(int[] arrayToSort)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            // Algorithm for Binary Search Tree
            var binSearchTree = new BinarySearchTree();
            binSearchTree.AddData(arrayToSort);
            var sortedArray = binSearchTree.InOrder();

            stopwatch.Stop();
            Console.WriteLine("Bin. Search Tr. elapsed time(ms) / ticks:{0,10} \t {1,15}", stopwatch.ElapsedMilliseconds, stopwatch.ElapsedTicks);
            return sortedArray;
        }


        private void Swap(int[] sortedList, int i, int j)
        {
            int tmp = sortedList[i];
            sortedList[i] = sortedList[j];
            sortedList[j] = tmp;
        }
    }
}
