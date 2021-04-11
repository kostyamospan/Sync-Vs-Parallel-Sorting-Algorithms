using System;

namespace SortTest
{
    public static class ArrayGenerator
    {
        public static int[] Generate1DimensionalArray(int size, int minVal = 0, int maxVal = 100)
        {
            var newArr = new int[size];
            var rnd = new Random();

            for (int i = 0; i < size; i++)
                newArr[i] = rnd.Next(minVal, maxVal);

            return newArr;
        }

        public static int[][] Generate2DimensionalArray(int size1, int size2, int minVal = 0, int maxVal = 100)
        {
            var newArr = new int[size1][];

            for (int i = 0; i < size1; i++)
                newArr[i] = Generate1DimensionalArray(size2, minVal, maxVal);

            return newArr;
        }
    }
}