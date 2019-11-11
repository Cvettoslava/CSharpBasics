using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysEx6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many elements will the array have?");
            int n;

            while (!int.TryParse(Console.ReadLine(),out n))
            {
                Console.WriteLine("Invalid value, please try again:");
            }
            int duplicateCounter = 0;
            int[] array = new int[n];

            for(int i = 0; i < n; i++)
            {
                Console.WriteLine($"Item {i} has value:");
                array[i] = int.Parse(Console.ReadLine());
            }

            // write comments and CWs
            for(int i = 0; i < n; i++)
            {
                bool duplicates = false;
                bool duplicatesBeforeCurrentElement = false;
                for(int j = 0; j < n; j++)
                {
                    if (array[i] == array[j] && i != j)
                    {
                        if (i > j)
                        {
                            duplicatesBeforeCurrentElement = true;
                        }
                        duplicates = true;
                        break;
                    }
                }

                if (duplicates && !duplicatesBeforeCurrentElement)
                {
                    duplicateCounter++;
                }
            }

            Console.WriteLine($"Number of duplicating items: {duplicateCounter}");
        }
    }
}
