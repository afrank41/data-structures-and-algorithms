using System;

namespace SortingAlgorithms
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] insertionArray = new int[] { 8, 3, 5, 6, 2, 1, 4, 9, 0 };

            Console.WriteLine("Input array: ");
            foreach (int num in insertionArray)
            {
                Console.Write($"{num} ");
            }
            Console.WriteLine("\n");

            InsertionSort(insertionArray);
            Console.WriteLine("Insertion sorted array: ");
            foreach (int num in insertionArray)
            {
                Console.Write($"{num} ");
            }
            Console.WriteLine("\n");

            int[] quickArray = new int[] { 8, 3, 5, 6, 2, 1, 4, 9, 0 };
            QuickSort(quickArray, 0, quickArray.Length - 1);

            Console.WriteLine("Quick sorted array: ");
            foreach (int num in quickArray)
            {
                Console.Write($"{num} ");
            }
            Console.WriteLine("\n");

            int[] mergeArray = new int[] { 8, 3, 5, 6, 2, 1, 4, 9, 0 };
            MergeSort(mergeArray);

            Console.WriteLine("Merge sorted array: ");
            foreach (int num in mergeArray)
            {
                Console.Write($"{num} ");
            }
            Console.WriteLine("\n");
        }

        /// <summary>
        /// Performs an insertion sort on an array
        /// </summary>
        /// <param name="array">array to be sorted</param>
        public static void InsertionSort(int[] array)
        {
            for (int i = 1; i < array.Length; i++)
            {
                int temp = array[i];
                int j = i - 1;

                while (j >= 0 && temp < array[j])
                {
                    array[j + 1] = array[j];
                    j--;
                }

                array[j + 1] = temp;
            }
        }

        /// <summary>
        /// Performs a quick sort on an array
        /// </summary>
        /// <param name="arr">The array to be sorted</param>
        /// <param name="left">The first index in the array</param>
        /// <param name="right">The the last index in the array</param>
        static void QuickSort(int[] arr, int left, int right)
        {
            if (left < right)
            {
                int position = Partition(arr, left, right);

                QuickSort(arr, left, position - 1);

                QuickSort(arr, position + 1, right);
            }
        }

        /// <summary>
        /// Partitions the specified array in a quick sort
        /// </summary>
        /// <param name="arr">The array to be partitioned</param>
        /// <param name="left">The first index in the array</param>
        /// <param name="right">The the last index in the array</param>
        /// <returns>return the index of the quick sorted array where it will be partitioned</returns>
        static int Partition(int[] arr, int left, int right)
        {
            int pivot = arr[right];
            int low = left - 1;

            for (int i = left; i < right; i++)
            {
                if (arr[i] <= pivot)
                {
                    low++;
                    Swap(arr, i, low);
                }
            }

            Swap(arr, right, low + 1);

            return low + 1;
        }

        /// <summary>
        /// Swaps two values in an array during a quick sort
        /// </summary>
        /// <param name="arr">The array being quick sorted</param>
        /// <param name="i">The current index of the array during the quick sort</param>
        /// <param name="low">The index of the porential lower value</param>
        static void Swap(int[] arr, int i, int low)
        {
            int temp;
            temp = arr[i];
            arr[i] = arr[low];
            arr[low] = temp;
        }


        /// <summary>
        /// Sort an array using a merge sort algorithm
        /// </summary>
        /// <param name="arr">the input array</param>
        public static void MergeSort(int[] arr)
        {
            if (arr.Length > 1)
            {
                int leftSize = arr.Length / 2;
                int rightSize = arr.Length - leftSize;

                int[] left = new int[leftSize];
                Array.Copy(arr, 0, left, 0, leftSize);

                int[] right = new int[rightSize];
                Array.Copy(arr, arr.Length / 2, right, 0, rightSize);

                MergeSort(left);
                MergeSort(right);
                Merge(left, right, arr);
            }
        }

        /// <summary>
        /// Merges two arrays into a main array
        /// </summary>
        /// <param name="left">The left array</param>
        /// <param name="right">The right array</param>
        /// <param name="arr">The main array created from the left and right arrays</param>
        /// <returns>Returns a sorted array</returns>
        public static int[] Merge(int[] left, int[] right, int[] arr)
        {
            int i = 0;
            int j = 0;
            int k = 0;

            while (i < left.Length && j < right.Length)
            {
                if (left[i] <= right[j])
                {
                    arr[k] = left[i++];
                }
                else
                {
                    arr[k] = right[j++];
                }

                k++;
            }

            if (i == left.Length)
            {
                Array.Copy(right, j, arr, k, right.Length - j);
            }
            else
            {
                Array.Copy(left, i, arr, k, left.Length - i);
            }

            return arr;
        }
    }
}