using System;

namespace SortTest.Sorts.Algorithms
{
    public class BubleSortAlgorithm<T> : ISortAlgorithm<T> where T : IComparable<T>
    {
        public string AlgorithmName { get; } = "Bubble Sort";

        public void Sort(ref T[] array)
        {
            T temp;
            for (int j = 0; j <= array.Length - 2; j++)
            {
                for (int i = 0; i <= array.Length - 2; i++)
                {
                    if (array[i].CompareTo(array[i + 1]) < 1)
                    {
                        temp = array[i + 1];
                        array[i + 1] = array[i];
                        array[i] = temp;
                    }
                }
            }
        }
    }
    
    
}