using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arraysEx1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[]
            {
                4,
                5,
                8,
                12
            };

            for(int i=0; i<arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}
