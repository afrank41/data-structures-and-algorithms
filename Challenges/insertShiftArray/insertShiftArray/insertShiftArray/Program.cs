using System;

namespace insertShiftArray
{
    class Program
    {
        static void Main(string[] args)
        {
            InsertShiftArray(new int[4] { 2, 4, 6, 8 }, 5);
        }

        static int[] InsertShiftArray(int[] arr, int num)
        {
            int[] newArray = new int[arr.Length + 1];
            decimal mid = Math.Ceiling((decimal)(newArray.Length / 2));
            int counter = 0;

            for (int i = 0; i < newArray.Length; i++)
            {
                if (i == mid)
                {
                    newArray[i] = num;
                }
                else
                {
                    newArray[i] = arr[counter];
                    counter++;
                }
            }

            Console.WriteLine($"Input number: {num}");
            Console.WriteLine("Numbers in input array:");
            foreach (int item in arr)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\nNumbers in new array:");
            foreach (int item in newArray)
            {
                Console.WriteLine(item);
            }

            return newArray;
        }
    }
}
