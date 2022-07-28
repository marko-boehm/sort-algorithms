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
    internal class BubbleSort : ISort
    {
        public int[] Sort(int[] list)
        {
            int[] sortedList = (int[])list.Clone();
            int index = sortedList.Length - 1;

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            // Algorithm for Bubble Sort
            while (index > 0)
            {
                for (int i = 0; i < index; i++)
                {
                    if (sortedList[i] > sortedList[i + 1])
                    {
                        Swap(sortedList, i, i + 1);
                    }
                }
                index--;
            }

            stopwatch.Stop();
            Console.WriteLine("Bubble Sort elapsed time(ms) / ticks:\t {0,10} \t {1,15}", stopwatch.ElapsedMilliseconds, stopwatch.ElapsedTicks);
            return sortedList;
        }


        private void Swap(int[] sortedList, int i, int j)
        {
            int tmp = sortedList[i];
            sortedList[i] = sortedList[j];
            sortedList[j] = tmp;
        }
    }
}
