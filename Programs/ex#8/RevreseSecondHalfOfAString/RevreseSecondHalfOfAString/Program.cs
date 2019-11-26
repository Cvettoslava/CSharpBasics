using System;
using System.Text;

namespace RevreseSecondHalfOfAString
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "12345678";

            StringBuilder builder = new StringBuilder(text.Substring(0, text.Length / 2));

            for(int i = text.Length - 1; i >= text.Length / 2; i--)
            {
                builder.Append(text[i]);
            }
            
            Console.WriteLine(text);

            text = builder.ToString();

            Console.WriteLine(text);
        }
    }
}
