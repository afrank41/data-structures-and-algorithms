using System;

namespace ArrayBinarySearch
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static int BinarySearch(int[] arr, int val)
        {
            int start = 0;
            int end = arr.Length - 1;

            for (int i = 0; i < arr.Length / 2; i++)
            {
                int mid = (end - start) / 2;

                if(val == arr[mid])
                {
                    return mid;
                }
                else if (val > arr[mid])
                {
                    start = mid + 1;
                }
                else if (val < arr[mid])
                {
                    end = mid - 1;
                }
            }
            return -1;
        }
    }
}
