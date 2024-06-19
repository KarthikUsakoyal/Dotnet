using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.Write("Enter a number: ");
            string input = Console.ReadLine();

            if (long.TryParse(input, out long number))
            {
                int sum = SumOfEvenDigits(Math.Abs(number));  // Use Math.Abs to handle negative numbers
                Console.WriteLine($"The sum of the even digits of {number} is: {sum}");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        }

        static int SumOfEvenDigits(long num)
        {
            int sum = 0;

            while (num != 0)
            {
                int digit = (int)(num % 10);
                if (digit % 2 == 0)
                {
                    sum += digit;
                }
                num /= 10;
            }

            return sum;
         */
            {
                Console.Write("Enter a number: ");
                string input = Console.ReadLine();

                if (long.TryParse(input, out long number))
                {
                    int sum = SumOfDigits(Math.Abs(number));  // Use Math.Abs to handle negative numbers
                    Console.WriteLine($"The sum of the digits of {number} is: {sum}");
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }
            }

            static int SumOfDigits(long num)
            {
                int sum = 0;

                while (num != 0)
                {
                    sum += (int)(num % 10);
                    num /= 10;
                }

                return sum;
            }
            Console.Write("Enter a number: ");
            string input = Console.ReadLine();

            if (long.TryParse(input, out long number))
            {
                int sum = SumOfEvenDigits(Math.Abs(number));  // Use Math.Abs to handle negative numbers
                Console.WriteLine($"The sum of the even digits of {number} is: {sum}");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        }

        static int SumOfEvenDigits(long num)
        {
            int sum = 0;

            while (num != 0)
            {
                int digit = (int)(num % 10);
                if (digit % 2 == 0)
                {
                    sum += digit;
                }
                num /= 10;
            }

            return sum;

        }
    }
}
