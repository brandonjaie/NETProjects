using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GuessingGame.BLL;

namespace GuessingGame.UI
{
    public class ConsoleOutput
    {
        public static void DisplayTitle()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Welcome to the Better, Testable, Guessing Game!");
            Console.ResetColor();
            Console.WriteLine("***********************************************");
            //Console.WriteLine("Press any key to start factoring...");
            //Console.ReadKey();
        }

        public static void DisplayGuessMessage(GuessResult result)
        {
            switch (result)
            {
                case GuessResult.Invalid:
                    DisplayInvalid();
                    break;
                case GuessResult.Higher:
                    DisplayHigher();
                    break;
                case GuessResult.Lower:
                    DisplayLower();
                    break;
                case GuessResult.Victory:
                    DisplayVictory();
                    break;
            }
        }

        private static void DisplayVictory()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nYou did it! You are awesome!");
            Console.ResetColor();
            //Console.WriteLine("\nPress any key to continue...");
            //Console.ReadKey();
            DisplayEndTitle();
        }

        private static void DisplayLower()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\nYour guess was too high, try something lower.");
            Console.ResetColor();
            //Console.WriteLine("\nPress any key to continue...");
            //Console.ReadKey();
        }

        private static void DisplayHigher()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\nYour guess was too low, try something higher.");
            Console.ResetColor();
            //Console.WriteLine("\nPress any key to continue...");
            //Console.ReadKey();
        }

        private static void DisplayInvalid()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nThat guess wasn't valid, try something between 1 and 20.");
            Console.ResetColor();
            //Console.WriteLine("\nPress any key to continue...");
            //Console.ReadKey();
        }

        public static void DisplayEndTitle()
        {
            Console.WriteLine("\n***********************************************");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Thank you for playing the Better, Testable, Guessing Game!\n");
            Console.ResetColor();
            Console.WriteLine("Press any key to QUIT");
            Console.ReadKey();

        }
    }
}
