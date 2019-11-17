using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SymbolCount
{
    class Program
    {
        static int CountSymbols(char symbol, string text)
        {
            int count = 0;

            foreach(char s in text)
            {
                if (s == symbol) count++;
            }

            return count;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Write the text:");
            string text = Console.ReadLine();

            Console.WriteLine("Which symbol do you want to count:");
            char symbol = Console.ReadKey().KeyChar;

            int count = CountSymbols(symbol, text);
            Console.WriteLine($"\nThere is '{symbol}' {count} times in the text");
        }
    }
}
