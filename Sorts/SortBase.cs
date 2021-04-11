using System;
using System.Threading.Tasks;
using SortTest.Sorts.Algorithms;

namespace SortTest.Sorts
{
    public abstract class SortBase<T> where T : IComparable<T>
    {
        protected readonly T[][] Array;
        protected readonly ISortAlgorithm<T> SortAlgorithm;

        public double SortingDuration { get; protected set; }
        public abstract string Name { get; }


        protected SortBase(T[][] arr, ISortAlgorithm<T> sortAlgorithm)
        {
            Array = arr;
            this.SortAlgorithm = sortAlgorithm;
        }

        public async Task Sort()
        {
            var timeStart = DateTime.Now;
            
            await SortArray();
            
            SortingDuration = (DateTime.Now - timeStart).TotalMilliseconds;
        }
        
        public void PrintArray()
        {
            for (int i = 0; i < Array.Length; i++)
            {
                for (int j = 0; j < Array[i].Length; j++)
                {
                    Console.Write("{0, 3}", Array[i][j]);
                }

                Console.WriteLine();
            }
            
            PrintSortingTime();
        }

        public void PrintSortingTime()
        {
            ConsoleColor.Green.WriteLine($"Time passed: {SortingDuration}ms");
        }
        
        protected void SortSubArray(ref T[] subArr)
        {
            SortAlgorithm.Sort(ref subArr);            
        }

        protected abstract Task SortArray();
    }

   
}