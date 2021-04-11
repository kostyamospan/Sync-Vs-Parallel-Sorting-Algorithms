using System;

namespace SortTest.Sorts.Algorithms
{
    public class QuickSortAlgorithm<T> : ISortAlgorithm<T> where T : IComparable<T>
    {
        public string AlgorithmName { get; } = "Quick Sort";


        public void Sort(ref T[] array)
        {
            QuickSort(ref array, 0, array.Length - 1);
        }
        
        private int Partition(ref T[] array, int minIndex, int maxIndex)
        {
            var pivot = minIndex - 1;
            for (var i = minIndex; i < maxIndex; i++)
            {
                if (array[i].CompareTo(array[maxIndex]) > 0)
                {
                    pivot++;
                    Swap(ref array[pivot], ref array[i]);
                }
            }

            pivot++;
            Swap(ref array[pivot], ref array[maxIndex]);
            return pivot;
        }

        private void QuickSort(ref T[] array, int minIndex, int maxIndex)
        {
            if (minIndex >= maxIndex) return ;

            var pivotIndex = Partition(ref array, minIndex, maxIndex);
            QuickSort(ref array, minIndex, pivotIndex - 1);
            QuickSort(ref array, pivotIndex + 1, maxIndex);
        }

        private void QuickSort(ref T[] array)
        {
            QuickSort(ref array, 0, array.Length - 1);
        }
        
        private static void Swap(ref T x, ref T y)
        {
            var t = x;
            x = y;
            y = t;
        }
    }
}