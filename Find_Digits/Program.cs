using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Find_Digits
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ask user for an integer
            Console.Write("Please enter an integer: ");
            int number;

            // Verify that user input is an integer
            while (!Int32.TryParse(Console.ReadLine(), out number))
            {
                Console.WriteLine();
                Console.WriteLine("Invalid input");
                Console.WriteLine();
                Console.Write("Please enter a integer: ");
            }
            Console.WriteLine(FindCountOfDivisableDigits(number));
        }

        // Finds the number of digits that exactly divide the number and returns the count
        private static int FindCountOfDivisableDigits(int number)
        {
            int digitCount = 0;
            int[] digits = BreakIntegerIntoDigits(number);
            foreach (var digit in digits)
            {
                if (digit == 0)
                {
                    continue;
                }
                
                if ( (number % digit) == 0)
                {
                    digitCount++;
                }
            }
            return digitCount;
        }

        // Splits number into digits and returns an array
        private static int[] BreakIntegerIntoDigits(int number)
        {
            string sNumber = number.ToString();
            int size = sNumber.Length;
            int[] digits = new int[size];
            size--;
            foreach (var digit in sNumber)
            {
                digits[size] = digit - '0';
                size--;
            }
            return digits;
        }
    }
}
