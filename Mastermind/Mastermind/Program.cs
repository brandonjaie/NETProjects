using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mastermind.UI
{
    public class Program
    {

        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();

                DisplayGameTitle();

                PlayMastermind();

                bool isPlaying = PlayAgain("\nPlay Again? Y / N: ");

                if (!isPlaying)
                {
                    break;
                }
            }

            DisplayGameEnd();

            Console.ReadKey();
        }

        private static void DisplayGameTitle()
        {
            Console.WriteLine("\n*******************************************");

            Console.WriteLine("\nMASTERMIND by Brandon Mathis");

            Console.WriteLine("\n*******************************************");

            Console.WriteLine("\nGuess the 4 digit number. Each digit, is a number, 1 thru 6");

            Console.WriteLine("\nYou get 10 tries. If a number you guessed is correct and in the right position, you'll get a +");

            Console.WriteLine("\nIf a number you guessed is correct, but in the wrong position, you'll get a -");

            Console.WriteLine("\nLet's Play!!!\n");

        }

        private static void PlayMastermind()
        {
            int[] answer = GenerateAnswer();
            int[] userGuess = new int[4];
            string[] guessResult = new string[4];
            string lineFormat = "{0,5} {1,5} {2,5} {3,5}";

            for (int i = 10; i > 0; i--)
            {
                Console.WriteLine($"\n**** Guess {i} ******************************\n");
                userGuess = GetGuessFromUser(userGuess);

                Console.WriteLine("\nYour Numbers are: \n");
                Console.WriteLine(lineFormat, userGuess[0], userGuess[1], userGuess[2], userGuess[3]);

                CompareUserGuessToAnswer(answer, userGuess, guessResult);

                Console.WriteLine();
                Console.WriteLine(lineFormat, guessResult[0], guessResult[1], guessResult[2], guessResult[3]);

                Console.WriteLine("\n*******************************************");

                Console.WriteLine();

                if (CheckGuessResult(guessResult))
                {

                    Console.WriteLine("\nYOU WIN! You are a Mastermind!!!\n");

                    break;
                }


                Array.Clear(guessResult, 0, guessResult.Length);
            }

        }

        private static int[] GenerateAnswer()
        {
            Random r = new Random();
            int[] answer = new int[4];

            for (int i = 0; i < 4; i++)
            {

                answer[i] = r.Next(1, 7);
            }

            return answer;
        }

        private static int[] GetGuessFromUser(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = GetIntFromUser($"Number {i + 1} - Enter a number between 1 and 6: ");
            }

            return arr;
        }

        private static int GetIntFromUser(string prompt)
        {
            while (true)
            {
                Console.Write(prompt);
                string input = Console.ReadLine();

                if (int.TryParse(input, out int number))
                {
                    if (number >= 1 && number <= 6)
                    {
                        return number;
                    }
                    else
                    {
                        Console.WriteLine("\nNumber out of range. Try again.\n");
                    }
                }
                else
                {
                    Console.WriteLine("\nYou didn't enter a number. Try again.\n");
                }
            }
        }

        private static string[] CompareUserGuessToAnswer(int[] answer, int[] userGuess, string[] guessResult)
        {
            for (int i = 0; i < answer.Length; i++)
            {
                for (int j = 0; j < userGuess.Length; j++)
                {
                    if (answer[i] == userGuess[j] && i == j)
                    {
                        guessResult[j] = "+";
                    }
                    else if (answer[i] == userGuess[j])
                    {
                        if (guessResult[j] != "+")
                            guessResult[j] = "-";
                    }
                    else if (answer[i] != userGuess[j] && guessResult[j] != "+" && guessResult[j] != "-")
                    {
                        guessResult[j] = "";
                    }
                }
            }

            return guessResult;
        }

        private static bool CheckGuessResult(string[] arr)
        {
            return Array.TrueForAll(arr, e => e == "+");
        }

        private static bool PlayAgain(string prompt)
        {
            while (true)
            {
                Console.Write(prompt);
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
                        Console.WriteLine("\nYou didn't indicate Y or N.");
                    }
                }
                else
                {
                    Console.WriteLine("\nPlease select a response.");
                }
            }
        }

        public static void DisplayGameEnd()
        {
            Console.WriteLine("\n*******************************************");
            Console.WriteLine("\nThank you for playing Mastermind");

            Console.WriteLine("\nPress any key to quit.");
        }
    }
}
