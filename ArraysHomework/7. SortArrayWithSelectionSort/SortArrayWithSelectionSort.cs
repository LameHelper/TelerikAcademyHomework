using System;
using System.Collections.Generic;
using System.Linq;

class SortArrayWithSelectionSort
{
    static void Main()
    {
        int[] unsortedArray = new int[] { 7, 3, 4, -6, 8, 5, -1, 4, 1 };
        int[] sortedArray = new int[unsortedArray.Length];
        for (int i = 0; i < unsortedArray.Length; i++)
        {
            sortedArray[i] = unsortedArray.Min();
            unsortedArray[Array.IndexOf(unsortedArray, unsortedArray.Min())] = int.MaxValue;
        }
    }
}

