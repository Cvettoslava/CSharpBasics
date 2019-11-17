using System;

namespace SimpleCalculator
{
    class Program
    {
        static double Sum(double a, double b)
        {
            return a + b;
        }

        static double Substract(double a, double b)
        {
            return a - b;
        }

        static double Devide(double a, double b)
        {
            return a / b;
        }

        static double Multiply(double a, double b)
        {
            return a * b;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Please select operation (+, -, /, *):");
            string operation = Console.ReadLine();

            Console.WriteLine("First number:");
            double a = double.Parse(Console.ReadLine());

            Console.WriteLine("Second number:");
            double b = double.Parse(Console.ReadLine());

            double? result = null;

            switch (operation)
            {
                case "+": result = Sum(a, b);
                    break;
                case "-": result = Substract(a, b);
                    break;
                case "*": result = Multiply(a, b);
                    break;
                case "/": result = Devide(a, b);
                    break;
                default:
                    break;
            }

            if(result.HasValue)
            {
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("Invalid operation!");
            }
        }
    }
}
