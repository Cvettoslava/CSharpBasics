using System;

namespace FibonacciNumbers
{
    class Program
    {
        static int GetFibonacciNumberByIndex(int index)
        {
            if (index <= 1) return 0;
            if (index == 2) return 1;

            return GetFibonacciNumberByIndex(index - 1) + GetFibonacciNumberByIndex(index - 2);
        }

        static void Main(string[] args)
        {
            // 1 2 3 4 5 6 7 8  9  10 11 12
            // 0 1 1 2 3 5 8 13 21 34 55 89
            while (true)
            {
                int finonacciIndex = int.Parse(Console.ReadLine());

                Console.WriteLine(GetFibonacciNumberByIndex(finonacciIndex));

            }
        }
    }
}
