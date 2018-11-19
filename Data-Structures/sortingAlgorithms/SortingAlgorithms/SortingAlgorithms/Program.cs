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
    }
}
