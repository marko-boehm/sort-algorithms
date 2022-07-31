using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortAlgorithms.SimpleSortings
{
    /// <summary>
    /// https://en.wikipedia.org/wiki/Selection_sort
    /// </summary>
    internal class SelectionSorting : ISort
    {
        public int[] Sort(int[] arrayToSort)
        {
            int[] sortedArray = (int[])arrayToSort.Clone();
            int minIndex;
            int minVal;

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            // Algorithm for Selection Sort
            for (int i = 0; i < sortedArray.Length; i++)
            {
                minIndex = i;
                minVal = sortedArray[i];
                for (int j = i + 1; j < sortedArray.Length; j++)
                {
                    if (sortedArray[j] < minVal)
                    {
                        minIndex = j;
                        minVal = sortedArray[j];
                    }
                }
                Swap(sortedArray, i, minIndex);
            }

            stopwatch.Stop();
            Console.WriteLine("Selection Sort elapsed time(ms) / ticks: {0,10} \t {1,15}", stopwatch.ElapsedMilliseconds, stopwatch.ElapsedTicks);
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
