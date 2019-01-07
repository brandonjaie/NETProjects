using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorizor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to The Factorizer | By Brandon Mathis");
            Console.WriteLine("=============================================\n");

            int number = GetNumberFromUser();

            Calculator.PrintFactors(number);
            Calculator.IsPerfectNumber(number);
            Calculator.IsPrimeNumber(number);

            Console.WriteLine("=============================================");
            Console.WriteLine("You are now leaving The Factorizer | Thank You\n");
            Console.WriteLine("Press any key to quit...");
            Console.ReadKey();
        }

        /// <summary>
        /// Prompt the user for an integer.  Make sure they enter a valid integer!
        /// 
        /// See the String Input lesson for TryParse() examples
        /// </summary>
        /// <returns>the user input as an integer</returns>
        static int GetNumberFromUser()
        {
            while (true)
            {
                Console.Write("Please enter a number: ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out int number))
                {
                    return number;
                }
                else
                {
                    Console.WriteLine("You didn't enter a number. Try again.\n");
                }
            }
        }
    }

    class Calculator
    {
        /// <summary>
        /// Given a number, print the factors per the specification
        /// </summary>
        public static void PrintFactors(int number)
        {
            Console.WriteLine($"\nThe factors of {number} are: ");
            Console.WriteLine("-------------------------\n");

            int totalFactors = 0;

            string factors = "";

            for (int i = 1; i < number; i++)
            {
                if (number % i == 0)
                {
                    totalFactors++;
                    factors += i + " ";
                    //Console.WriteLine("\t" + i + "\n");
                }
            }
            Console.WriteLine(factors + "\n");
            Console.WriteLine("-------------------------\n");
            if (totalFactors == 1)
            {
                Console.WriteLine($"There is {totalFactors} factor in the number {number}.\n");
            }
            else
            {
                Console.WriteLine($"There are {totalFactors} factors in the number {number}.\n");
            }
            
        }

        /// <summary>
        /// Given a number, print if it is perfect or not
        /// </summary>
        public static void IsPerfectNumber(int number)
        {
            int sum = 0;

            for (int i = 1; i < number; i++)
            {
                if (number % i == 0)
                {
                    sum += i;
                }
            }

            if (sum == number)
            {
                Console.WriteLine($"The number {number} is a perfect number.\n");
            }
            else
            {
                Console.WriteLine($"The number {number} is NOT a perfect number.\n");
            }
        }

        /// <summary>
        /// Given a number, print if it is prime or not
        /// </summary>
        public static void IsPrimeNumber(int number)
        {
            int totalFactors = 0;

            for (int i = 1; i < number; i++)
            {
                if (number % i == 0)
                {
                    totalFactors++;
                }
            }

            if (totalFactors == 1)
            {
                Console.WriteLine($"The number {number} is a prime number.\n");
            }
            else
            {
                Console.WriteLine($"The number {number} is NOT a prime number.\n");
            }
        }
    }
}
