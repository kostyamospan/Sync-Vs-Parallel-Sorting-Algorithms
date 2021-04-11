using System;
using System.Threading.Tasks;
using SortTest.Sorts.Algorithms;

namespace SortTest.Sorts
{
    public class SortParallel<T> : SortBase<T> where T : IComparable<T>
    {
        public override string Name { get; } = "Parallel Sort";

        public SortParallel(T[][] arr, ISortAlgorithm<T> sortAlgorithm) : base(arr, sortAlgorithm)
        {
        }


        protected override Task SortArray() => Task.Run(
            () => { Parallel.For(0, Array.Length, (i, state) => { SortSubArray(ref Array[i]); }); }
        );
    }
}