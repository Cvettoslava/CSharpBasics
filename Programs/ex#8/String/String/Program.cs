using System.Text;

namespace String
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "This is a test String";

            StringBuilder builder = new StringBuilder(text);

            builder.Replace("s", "ss");
            builder.Replace("S", "SS");

            text = builder.ToString();
            System.Console.WriteLine(text);
        }
    }
}
