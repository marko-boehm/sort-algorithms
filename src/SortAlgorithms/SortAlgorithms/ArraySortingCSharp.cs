using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortAlgorithms
{
    internal class ArraySortingCSharp : ISort
    {
        public int[] Sort(int[] arrayToSort)
        {
            int[] sortedArray = (int[])arrayToSort.Clone();

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            Array.Sort(sortedArray);

            stopwatch.Stop();
            Console.WriteLine("Array (C#) Sort elapsed time(ms) / ticks:{0,10} \t {1,15}", stopwatch.ElapsedMilliseconds, stopwatch.ElapsedTicks);
            return sortedArray;
        }
    }
}
