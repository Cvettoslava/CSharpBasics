using System;

namespace arraysEx5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Task:
            // Write a program in C# Sharp to copy the elements one array into another array.

            Console.WriteLine("How many elements will the array have?");
            int n = int.Parse(Console.ReadLine());
            int[] arrayToCopy = new int[n];
            int[] copiedArray = new int[n];

            for(int i=0;i<n;i++)
            {
                Console.WriteLine($"Write the {i} element of the array:");
                arrayToCopy[i] = int.Parse(Console.ReadLine());
            }

            for(int i=0;i<n;i++)
            {
                copiedArray[i] = arrayToCopy[i];
            }

            for(int i=0;i<n;i++)
            {
                Console.WriteLine($"The {i} element of the copied array is:");
                Console.WriteLine(copiedArray[i]);
            }
        }
    }
}
