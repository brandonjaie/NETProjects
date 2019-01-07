using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorizer.UI
{
    public class ConsoleInput
    {
        public static int GetIntFromUser()
        {
            //Console.Clear();
            int output;
            string input;

            while (true)
            {
                Console.Write("\nEnter a whole number to Factorize: ");
                input = Console.ReadLine();

                if (int.TryParse(input, out output))
                {
                    return output;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nThat was not a valid number! Press any key to continue...");
                    Console.ResetColor();
                    Console.ReadKey();
                }
            }
        }

        public static bool PlayAgain()
        {
            while (true)
            {
                Console.Write("\nPlay Again? Y / N: ");
                string input = Console.ReadLine();

                if (!string.IsNullOrEmpty(input))
                {
                    string newInput = input.ToLower().Trim();

                    if (newInput == "y")
                    {
                        return true;
                    }
                    else if (newInput == "n")
                    {
                        return false;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\nYou didn't indicate Y or N.");
                        Console.ResetColor();
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nPlease select a response.");
                    Console.ResetColor();
                }
            }
        }
    }
}

