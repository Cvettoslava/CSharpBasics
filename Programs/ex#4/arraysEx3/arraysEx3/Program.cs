using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arraysEx3
{
    class Program
    {
        static void Main(string[] args)
        {
            // INPUT : gosho qde leshta
            // OUTPUT :
            // gos
            // ho 
            // qde
            //  le
            // sht
            // a

            string input = Console.ReadLine();

            for(int i=0; i<input.Length;i++)
            {
                if(i % 3 == 0)
                {
                    Console.WriteLine();
                }

                Console.Write(input[i]);
            }
        }
    }
}
