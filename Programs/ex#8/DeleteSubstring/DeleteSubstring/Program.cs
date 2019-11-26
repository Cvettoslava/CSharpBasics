using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeleteSubstring
{
    class Program
    {
        static void Main(string[] args)
        {
            //string text = "This is my string";
            //string substring = "string";
            //string result = "This is my ";

            Console.WriteLine("Please, enter a string");

            var input = new StringBuilder(Console.ReadLine());

            Console.WriteLine("Please, enter a sub string to be deleted");

            string subString = Console.ReadLine();
            if(!string.IsNullOrEmpty(subString))
                input = input.Replace(subString, string.Empty);

            string text = input.ToString();
            Console.WriteLine(text);
        }
    }
}
