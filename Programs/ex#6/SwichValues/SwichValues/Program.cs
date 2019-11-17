using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwichValues
{
    class Program
    {
        static void SwitchValues(ref int a,ref  int b)
        {
            int c = a;
            a = b;
            b = c;
        }

        static void SetValue(out int a, int b)
        {
            a = b;
        }

        static void Main(string[] args)
        {
            int a = 8;
            int b = 5;
            SwitchValues(ref a,ref b);
            SetValue(out int c, 8);

            Console.WriteLine($"a - {a}, b - {b}, c - {c}");
        }
    }
}
