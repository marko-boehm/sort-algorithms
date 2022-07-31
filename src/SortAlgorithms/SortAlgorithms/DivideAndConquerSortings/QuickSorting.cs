using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortAlgorithms.DivideAndConquerSortings
{
    internal class QuickSorting : ISort
    {
        public int[] Sort(int[] arrayToSort)
        {
            int[] sortedArray = (int[])arrayToSort.Clone();

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            //Algorithm
            QuickSort(sortedArray, 0, sortedArray.Length - 1);

            stopwatch.Stop();
            Console.WriteLine("Quick Sort elapsed time(ms) / ticks:\t {0,10} \t {1,15}", stopwatch.ElapsedMilliseconds, stopwatch.ElapsedTicks);
            return sortedArray;
        }

        private int[] QuickSort(int[] arrayToSort, int leftIndex, int rightIndex)
        {
            if (leftIndex < rightIndex)
            {
                var pivotElemIndex = (leftIndex + rightIndex) / 2;
                var pivotElem = arrayToSort[pivotElemIndex];
                var preSortedLeft = new Stack<int>();
                var preSortedRight = new Stack<int>();


                // Check left array part
                for (int i = leftIndex; i < rightIndex + 1; i++)
                {
                    if (i == pivotElemIndex)
                        continue;

                    if (arrayToSort[i] < pivotElem)
                    {
                        preSortedLeft.Push(arrayToSort[i]);
                    }
                    else
                    {
                        preSortedRight.Push(arrayToSort[i]);   
                    }
                }

                pivotElemIndex = preSortedLeft.Count() + leftIndex;
                arrayToSort[pivotElemIndex] = pivotElem;
                CopyStackToArray(arrayToSort, preSortedLeft, leftIndex);
                CopyStackToArray(arrayToSort, preSortedRight, pivotElemIndex + 1);


                QuickSort(arrayToSort, leftIndex, pivotElemIndex - 1);
                QuickSort(arrayToSort, pivotElemIndex + 1, rightIndex);
            }
            
            return arrayToSort;
        }

        private void CopyStackToArray (int[] arrayToSort, Stack<int> preSortedStack, int startIndex)
        {
            int i = startIndex;
            while (preSortedStack.Count > 0)
            {
                arrayToSort[i] = preSortedStack.Pop();
                i++;
            }
        }
    }
}
