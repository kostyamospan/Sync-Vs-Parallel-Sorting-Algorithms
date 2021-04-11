using System;

namespace SortTest.Sorts.Algorithms
{
    public class MergeSortAlgorithm<T> : ISortAlgorithm<T> where T: IComparable<T>
    {
        public string AlgorithmName { get; } = "Merge Sort";
        
        public void Sort(ref T[] array)
        {
            MergeSort(ref array, 0, array.Length - 1);
        }
        
        private void Merge(ref T[] array, int lowIndex, int middleIndex, int highIndex)
        {
            var left = lowIndex;
            var right = middleIndex + 1;
            var tempArray = new T[highIndex - lowIndex + 1];
            var index = 0;

            while ((left <= middleIndex) && (right <= highIndex))
            {
                if (array[left].CompareTo(array[right]) > 0)
                {
                    tempArray[index] = array[left];
                    left++;
                }
                else
                {
                    tempArray[index] = array[right];
                    right++;
                }

                index++;
            }

            for (var i = left; i <= middleIndex; i++)
            {
                tempArray[index] = array[i];
                index++;
            }

            for (var i = right; i <= highIndex; i++)
            {
                tempArray[index] = array[i];
                index++;
            }

            for (var i = 0; i < tempArray.Length; i++)
                array[lowIndex + i] = tempArray[i];
        }

        private void MergeSort(ref T[] array, int lowIndex, int highIndex)
        {
            if (lowIndex >= highIndex) return;
            
            var middleIndex = (lowIndex + highIndex) / 2;
            MergeSort(ref array, lowIndex, middleIndex);
            MergeSort(ref array, middleIndex + 1, highIndex);
            Merge(ref array, lowIndex, middleIndex, highIndex);
        }
    }
}