using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[5];
            array = new int[]
            {
                5,
                8,
                12,
                28,
                1
            };
            array[0] = 9;

            int[,] arr2;

            arr2 = new int[2, 2]
            {
                {
                    1,
                    8
                },

                {
                    2,
                    5
                }
            };

            int[][] jArr = new int[2][];

            jArr = new int[][]
            {
                new int[5],
                new int[3]
            };
        }
    }
}
