using System;
using System.Threading.Tasks;
using SortTest.Sorts.Algorithms;

namespace SortTest
{
    class Program
    {
        static async Task Main(string[] args)
        {
            ISortAlgorithm<int>[] sortAlgorithms =
            {
                new BubleSortAlgorithm<int>(),
                new ShakerSortAlgorithm<int>(),
                new MergeSortAlgorithm<int>(),
                new QuickSortAlgorithm<int>()
            };

            foreach (var sort in sortAlgorithms)
            {
                SortTest<int> sortTest1 = new(ArrayGenerator.Generate2DimensionalArray(10, 10), sort);
                SortTest<int> sortTest2 = new(ArrayGenerator.Generate2DimensionalArray(100, 100), sort);
                SortTest<int> sortTest3 = new(ArrayGenerator.Generate2DimensionalArray(1000, 1000), sort);

                ConsoleColor.Magenta.WriteLine($"\n\n Testing with {sort.AlgorithmName}\n");


                ConsoleColor.Cyan.WriteLine("Sorting test №1\n" +
                                            "Input data: Small Array (10x10)");

                await sortTest1.TestSorting();

                ConsoleColor.Cyan.WriteLine("\nSorting test №2\n" +
                                            "Input data: Medium Array (100x100)");

                await sortTest2.TestSorting();

                ConsoleColor.Cyan.WriteLine("\nSorting test №3\n" +
                                            "Input data: Big Array (1000x1000)");
                
                await sortTest3.TestSorting();
            }
        }
    }
}