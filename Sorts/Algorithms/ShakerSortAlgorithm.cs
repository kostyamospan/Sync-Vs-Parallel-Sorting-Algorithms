using System;

namespace SortTest.Sorts.Algorithms
{
    public class ShakerSortAlgorithm<T> : ISortAlgorithm<T> where T : IComparable<T>
    {
        public string AlgorithmName { get; } = "Shaker Sort";

        public void Sort(ref T[] array)
        {
            for (var i = 0; i < array.Length / 2; i++)
            {
                var swapFlag = false;

                for (var j = i; j < array.Length - i - 1; j++)
                {
                    if (array[j].CompareTo(array[j + 1]) >= 0) continue;
                    
                    Swap(ref array[j], ref array[j + 1]);
                    swapFlag = true;
                }

                for (var j = array.Length - 2 - i; j > i; j--)
                {
                    if (array[j - 1].CompareTo(array[j]) >= 0) continue;
                    
                    Swap(ref array[j - 1], ref array[j]);
                    swapFlag = true;
                }

                if (!swapFlag)
                    break;
            }
        }

        private static void Swap(ref T e1, ref T e2)
        {
            var temp = e1;
            e1 = e2;
            e2 = temp;
        }
    }
}