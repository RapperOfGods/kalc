using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kalc.SortArray
{
    class QuickSort : ISortArray
    {

        public int[] sort(int[] Array)
        {

            return Array.Length > 1 ? Quicksort(Array, 0, Array.Length - 1) : Array;
        }

        static private int[] Quicksort(int[] Array, int left, int right)
        {
            if (left == right) return Array;
            int i = left + 1;
            int j = right;
            int pivot = Array[left];

            while (i < j)
            {
                if (Array[i] <= pivot) i++;
                else if (Array[j] > pivot) j--;
                else
                {
                    int m = Array[i]; 
                    Array[i] = Array[j]; 
                    Array[j] = m;
                }
            }

            if (Array[j] <= pivot)
            {
                int m = Array[left]; Array[left] = Array[right]; Array[right] = m;
                Quicksort(Array, left, right - 1);
            }
            else
            {
                Quicksort(Array, left, i - 1);
                Quicksort(Array, i, right);
            }

            return Array;
        }

    }
}
