using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortAlgorithms.SimpleSortings
{
    /// <summary>
    /// Wiki: https://en.wikipedia.org/wiki/Insertion_sort
    /// </summary>
    internal class InsertionSort : ISort
    {
        public int[] Sort(int[] arrayToSort)
        {
            int[] sortedArray = new int[arrayToSort.Length];
            sortedArray[0] = arrayToSort[0];
            int index;
            int sortValue;

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            // Algorithm for Insertion Sort
            for (int i = 1; i < arrayToSort.Length; i++)
            {
                sortedArray[i] = arrayToSort[i];
                sortValue = sortedArray[i];
                index = i - 1;

                while (index >= 0 && sortedArray[index] > sortValue)
                {
                    sortedArray[index + 1] = sortedArray[index];
                    index--;
                }

                sortedArray[index + 1] = sortValue;
            }

            stopwatch.Stop();
            Console.WriteLine("Insertion Sort elapsed time(ms) / ticks: {0,10} \t {1,15}", stopwatch.ElapsedMilliseconds, stopwatch.ElapsedTicks);
            return sortedArray;
        }
    }
}
