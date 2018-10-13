using System;

namespace FibNums
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What nth number of the Fibonacci sequence do you want? ");
            int input = int.Parse(Console.ReadLine());
            int fibNum = FibNums(input);
            Console.WriteLine($"\nThe number you wanted is {fibNum}");
        }

        static int FibNums(int num)
        {
            int a = 0;
            int b = 1;
            int fib = 0;

            for (int i = 0; i < num - 2; i++)
            {
                fib = a + b;
                a = b;
                b = fib;
            }

            return fib;
        }
    }
}
