using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortAlgorithms.SimpleSortings
{
    /// <summary>
    /// Wiki: https://en.wikipedia.org/wiki/Bubble_sort
    /// </summary>
    public class BubbleSorting : ISort
    {
        public int[] Sort(int[] arrayToSort)
        {
            int[] sortedArray = (int[])arrayToSort.Clone();
            int index = sortedArray.Length - 1;

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            // Algorithm for Bubble Sort
            while (index > 0)
            {
                for (int i = 0; i < index; i++)
                {
                    if (sortedArray[i] > sortedArray[i + 1])
                    {
                        Swap(sortedArray, i, i + 1);
                    }
                }
                index--;
            }

            stopwatch.Stop();
            Console.WriteLine("Bubble Sort elapsed time(ms) / ticks:\t {0,10} \t {1,15}", stopwatch.ElapsedMilliseconds, stopwatch.ElapsedTicks);
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
