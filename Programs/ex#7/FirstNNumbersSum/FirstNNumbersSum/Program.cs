using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstNNumbersSum
{
    class Program
    {
        static int GetFirstNNumbersSum(int n)
        {
            if (n == 1) return n;

            return GetFirstNNumbersSum(n - 1) + n;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("What is the value of N?");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine($"The sum of the numbers from 1 to {n} = {GetFirstNNumbersSum(n)}");
        }
    }
}
