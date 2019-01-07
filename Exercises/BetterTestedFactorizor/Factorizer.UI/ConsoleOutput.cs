using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Factorizer.BLL;

namespace Factorizer.UI
{
    public class ConsoleOutput
    {
        public static void DisplayTitle()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Welcome to the Better, Testable, Factorizer!");
            Console.ResetColor();
            Console.WriteLine("********************************************");
            //Console.WriteLine("Press any key to start factoring...");
            //Console.ReadKey();
        }

        public static void DisplayFactors(int number)
        {
            FactorFinder ff = new FactorFinder();
            string factors = "";

            int[] factorList = ff.GetFactors2(number);

            for (int i = 0; i < factorList.Length; i++)
            {
                factors += factorList[i] + "  ";
            }

            Console.WriteLine($"\nThe factors of {number} are: ");
            Console.WriteLine("|-------------------------------------------|\n");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(factors + "\n");
            Console.ResetColor();
            Console.WriteLine("|-------------------------------------------|\n");

            Console.WriteLine("Press any key to continue...\n");
            Console.ReadKey();
        }

        public static void DisplayPrimeNumber(int number)
        {
            PrimeChecker pc = new PrimeChecker();
            bool isPrime = pc.IsPrimeNumber(number);

            Console.WriteLine("|-------------------------------------------|\n");
            Console.ForegroundColor = ConsoleColor.Magenta;
            if (isPrime)
            {
                Console.WriteLine($"The number {number} is a prime number.\n");
            }
            else
            {
                Console.WriteLine($"The number {number} is NOT a prime number.\n");
            }
            Console.ResetColor();
            Console.WriteLine("|-------------------------------------------|\n");

            Console.WriteLine("Press any key to continue...\n");
            Console.ReadKey();
        }

        public static void DisplayPerfectNumber(int number)
        {
            PerfectChecker pc = new PerfectChecker();
            bool isPerfect = pc.IsPerfectNumber(number);

            Console.WriteLine("|-------------------------------------------|\n");
            Console.ForegroundColor = ConsoleColor.Magenta;
            if (isPerfect)
            {
                Console.WriteLine($"The number {number} is a perfect number.\n");
            }
            else
            {
                Console.WriteLine($"The number {number} is NOT a perfect number.\n");
            }
            Console.ResetColor();

            Console.WriteLine("|-------------------------------------------|\n");

            //Console.WriteLine("Press any key to continue...\n");
            //Console.ReadKey();
        }

        public static void DisplayEndTitle()
        {
            Console.WriteLine("\n**********************************************");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Thank you for playing The Factorizer!\n");
            Console.ResetColor();
            Console.WriteLine("Press any key to QUIT");
            Console.ReadKey();

        }
    }
}
