using System;

namespace PrimeNumberFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the lower limit of the range: ");
            int lowerLimit = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the upper limit of the range: ");
            int upperLimit = int.Parse(Console.ReadLine());

            Console.WriteLine("The prime numbers between {0} and {1} are: ", lowerLimit, upperLimit);

            for (int i = lowerLimit; i <= upperLimit; i++)
            {
                int count = 0;
                for (int j = 2; j <= i / 2; j++)
                {
                    if (i % j == 0)
                    {
                        count++;
                        break;
                    }
                }
                if (count == 0 && i != 1)
                {
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine();
        }
    }
}
