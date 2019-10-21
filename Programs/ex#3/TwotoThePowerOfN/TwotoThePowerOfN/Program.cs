using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwotoThePowerOfN
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int currentVal = 1;

            for(int i = 0; i <= n; i++)
            {
                Console.WriteLine(currentVal);
                currentVal *= 2;
            }

            // Only even

            currentVal = 1;
            for (int i = 0; i <= n; i+=2)
            {
                Console.WriteLine(currentVal);
                currentVal *= 4;
            }
        }
    }
}
