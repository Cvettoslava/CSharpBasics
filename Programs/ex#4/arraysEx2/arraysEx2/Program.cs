using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arraysEx2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please write the size of the array:");
            int sizeOfArray = int.Parse(Console.ReadLine());

            int[] array = new int[sizeOfArray];

            for(int i=0;i<array.Length; i++)
            {
                Console.WriteLine($"Please write the element with index '{i}':");
                array[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"\narray[{i}] is equal to {array[i]}");
            }
        }
    }
}
