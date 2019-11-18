using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefAndValTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 16;
            // n-1
            // n--
            // --n
            Console.WriteLine(n--); // 16
            Console.WriteLine(--n); // 14
            Console.WriteLine(n - 1); // 13
            Console.WriteLine(n); // 14
        }
    }
}
