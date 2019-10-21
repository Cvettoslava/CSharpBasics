using System;

namespace LeftAndRightSum
{
    class Program
    {
        static void Main(string[] args)
        {
            // First
            int n = int.Parse(Console.ReadLine());
            int firstSum = 0;
            int currentSum = 0;

            for(int i=0;i<2*n;i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());

                if(i==n)
                {
                    firstSum = currentSum;
                    currentSum = 0;
                }

                currentSum += currentNumber;
            }

            if(currentSum == firstSum)
            {
                Console.WriteLine($"Yes {currentSum}");
            }
            else
            {
                Console.WriteLine($"No {currentSum} {firstSum}");
            }

            // Second
            Console.WriteLine("Try again with the same n:");
            int leftSum = 0;
            int rightSum = 0;
            for (int i = 0; i < n; i++)
            {
                leftSum = leftSum + int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < n; i++)
            {
                rightSum = rightSum + int.Parse(Console.ReadLine());
            }
            if (leftSum == rightSum)
                Console.WriteLine("Yes, sum = " + leftSum);
            else
                Console.WriteLine("No, diff = " +
                Math.Abs(rightSum - leftSum));
            
            // Third
            Console.WriteLine("Try again with the same n:");
            leftSum = 0;
            rightSum = 0;
            for (int i = 0; i < 2*n; i++)
            {
                if (i < n)
                {
                    leftSum = leftSum + int.Parse(Console.ReadLine());
                }
                else
                {
                    rightSum = rightSum + int.Parse(Console.ReadLine());
                }
            }
            if (leftSum == rightSum)
                Console.WriteLine("Yes, sum = " + leftSum);
            else
                Console.WriteLine("No, diff = " +
                Math.Abs(rightSum - leftSum));
        }
    }
}
