using System;

namespace ReccursiveNumbersFrom1toN
{
    class Program
    {
        static void PrintNumbersFromOneToN(int n, int startingValue)
        {
            if (startingValue > n) return;

            Console.WriteLine(startingValue);
            PrintNumbersFromOneToN(n, startingValue + 1);
        }

        static void PrintNumbersFromNToOne(int n)
        {
            if (n < 1) PrintNumbersFromNToOne(n - 1); ;

            Console.WriteLine(n);
        }

        static void PrintNumbersFromOneToN(int n)
        {
            if (n > 1) PrintNumbersFromOneToN(n - 1);

            Console.WriteLine(n);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("What is the value of n?");
            int n = int.Parse(Console.ReadLine());
        }
    }
}
