using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    class Program
    {
        static int GetFactorialNonRecursive(int a)
        {
            int factorial = 1;
            for(int i = 1; i <= a; i++)
            {
                factorial *= i;
            }

            return factorial;
        }

        static int GetFactorial(int a)
        {
            if (a == 1) return 1;

            return a * GetFactorial(a - 1);
        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int factorial = GetFactorial(n);

            Console.WriteLine($"{n}! = {factorial}");
        }
    }
}
