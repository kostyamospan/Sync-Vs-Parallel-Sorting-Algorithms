using System;
using System.Threading.Tasks;
using SortTest.Sorts;
using SortTest.Sorts.Algorithms;

namespace SortTest
{
    class SortTest<T> where T : IComparable<T>
    {
        private readonly SortBase<T>[] _sorts;


        private ISortAlgorithm<T> _sortAlgorithm;

        private T[][] _array;

        public SortTest(T[][] array, ISortAlgorithm<T> sortAlgorithm)
        {
            _array = array;

            this._sortAlgorithm = sortAlgorithm;

            _sorts = new SortBase<T>[]
            {
                new SortSync<T>(array, sortAlgorithm),
                new SortParallel<T>(array, sortAlgorithm)
            };
        }

        public async Task TestSorting()
        {
            foreach (var sort in _sorts)
            {
                await sort.Sort();
                ConsoleColor.DarkGreen.Write(sort.Name + ": ");
                
                sort.PrintSortingTime();
                Console.WriteLine();
            }
        }
    }
}