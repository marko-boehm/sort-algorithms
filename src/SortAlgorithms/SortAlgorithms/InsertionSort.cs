using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortAlgorithms
{
    /// <summary>
    /// Wiki: https://en.wikipedia.org/wiki/Insertion_sort
    /// </summary>
    internal class InsertionSort : ISort
    {
        public int[] Sort(int[] list)
        {
            int[] sortedList = new int[list.Length];
            sortedList[0] = list[0];
            int index;
            int sortValue;
            
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            // Algorithm for Insertion Sort
            for (int i = 1; i < list.Length; i++)
            {
                sortedList[i] = list[i];
                sortValue = sortedList[i];
                index = i - 1;               

                while (index >= 0 && sortedList[index] > sortValue )
                {
                    sortedList[index + 1] = sortedList[index];
                    index--;
                }

                sortedList[index + 1] = sortValue;
            }

            stopwatch.Stop();
            Console.WriteLine("Insertion Sort elapsed time(ms) / ticks: {0,10} \t {1,15}", stopwatch.ElapsedMilliseconds, stopwatch.ElapsedTicks);
            return sortedList;
        }
    }
}
