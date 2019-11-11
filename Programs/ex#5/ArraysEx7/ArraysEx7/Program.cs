using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysEx7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many elements will the array have?");
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Item {i} has value:");
                array[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("The unique items from the array are:");
            for(int i = 0; i < n; i++)
            {
                bool isUnique = true;
                for(int j = 0; j < n; j++)
                {
                    if(array[i] == array[j] && i != j)
                    {
                        isUnique = false;
                        break;
                    }
                }
                if (isUnique) Console.WriteLine(array[i]);
            }
        }
    }
}
