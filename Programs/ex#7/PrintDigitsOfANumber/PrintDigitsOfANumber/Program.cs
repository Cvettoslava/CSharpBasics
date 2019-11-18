using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintDigitsOfANumber
{
    class Program
    {
        static void PrintDigits(int n)
        {
            if (n / 10 == 0) Console.WriteLine(n); // n < 10
            else
            {
                PrintDigits(n / 10);
                Console.WriteLine(n % 10);
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Write a number:");
            int n = int.Parse(Console.ReadLine());

            PrintDigits(n);
        }
    }
}
