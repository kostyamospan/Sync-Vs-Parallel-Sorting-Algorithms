using System;
using System.Threading.Tasks;
using SortTest.Sorts.Algorithms;

namespace SortTest.Sorts
{
    public class SortSync<T> : SortBase<T> where T : IComparable<T>
    {
        public override string Name { get; } = "Synchronized Sort";

        public SortSync(T[][] arr, ISortAlgorithm<T> sortAlgorithm) : base(arr, sortAlgorithm)
        {
        }

        protected override Task SortArray() => Task.Run(_sortArr);


        private void _sortArr()
        {
            for (int i = 0; i < Array.Length; i++)
                SortSubArray(ref Array[i]);
        }
    }
}