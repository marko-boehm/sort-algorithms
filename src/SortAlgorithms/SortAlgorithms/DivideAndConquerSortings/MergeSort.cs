using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortAlgorithms.DivideAndConquerSortings
{
    internal class MergeSort : ISort
    {
        public int[] Sort(int[] arrayToSort)
        {
            int[] sortedList = (int[])arrayToSort.Clone();

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            //Algorithm
            DivideSortMerge(sortedList, 0, sortedList.Length - 1);

            stopwatch.Stop();
            Console.WriteLine("Merge Sort elapsed time(ms) / ticks:\t {0,10} \t {1,15}", stopwatch.ElapsedMilliseconds, stopwatch.ElapsedTicks);
            return sortedList;
        }

        private int[] DivideSortMerge(int[] arrayToSort, int leftIndex, int rightIndex)
        {
            if (leftIndex < rightIndex)
            {
                var midIndex = (leftIndex + rightIndex) / 2;

                DivideSortMerge(arrayToSort, leftIndex, midIndex);
                DivideSortMerge(arrayToSort, midIndex + 1, rightIndex);

                SortAndMerge(arrayToSort, leftIndex, midIndex, rightIndex);
            }
            

            return arrayToSort;
        }

        private void SortAndMerge(int[] arrayToSort, int leftIndex, int midIndex, int rightIndex)
        {
            int[] sortedArray = new int[rightIndex - leftIndex + 1];
            int leftIndexCount = 0;
            int rightIndexCount = 0;
            int sortedArrayIndex = 0;

            // Compare left array with right array
            while (leftIndex + leftIndexCount <= midIndex && midIndex + 1 + rightIndexCount <= rightIndex)
            {
                if (arrayToSort[leftIndex + leftIndexCount] <= arrayToSort[midIndex + 1 + rightIndexCount])
                {
                    sortedArray[sortedArrayIndex] = arrayToSort[leftIndex + leftIndexCount];
                    leftIndexCount++;
                }
                else
                {
                    sortedArray[sortedArrayIndex] = arrayToSort[midIndex + 1 + rightIndexCount];
                    rightIndexCount++;
                }
                sortedArrayIndex++;
            }

            // Add remaining from left array
            while (leftIndex + leftIndexCount <= midIndex)
            {
                sortedArray[sortedArrayIndex] = arrayToSort[leftIndex + leftIndexCount];
                leftIndexCount++;
                sortedArrayIndex++;
            }

            // Add reimaining from right array
            while (midIndex + 1 + rightIndexCount <= rightIndex)
            {
                sortedArray[sortedArrayIndex] = arrayToSort[midIndex + 1 + rightIndexCount];
                rightIndexCount++;
                sortedArrayIndex++;
            }


            for (int i = 0; i < sortedArray.Length; i++)
            {
                arrayToSort[leftIndex + i] = sortedArray[i];
            }


        }



    }
}
