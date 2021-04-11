using System;

namespace SortTest.Sorts.Algorithms
{
    public interface ISortAlgorithm<T> where T : IComparable<T>
    {
        string AlgorithmName { get; }
        void Sort(ref T[] array);
    }
}