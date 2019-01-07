using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("The House of Guess | By Brandon Mathis");
            Console.ResetColor();
            Console.WriteLine("=============================================\n");

            string playerName = GetNameFromUser("Enter your name: ");

            while (true)
            {
                int gameMode = SelectGameMode("\nSelect Game Mode\n\nEasy - 1 | Normal - 2 | Hard - 3\n\n");

                PlayGuessingGame(playerName, gameMode);

                bool isPlaying = PlayAgain("\nPlay Again? Y / N: ");

                if (!isPlaying)
                {
                    break;
                }
            }

            Console.WriteLine("\n=============================================");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Thank you for playing the House of Guess");
            Console.ResetColor();

            Console.WriteLine("\nPress any key to quit.");
            Console.ReadKey();
        }

        static string GetNameFromUser(string prompt)
        {
            while (true)
            {
                Console.Write(prompt);
                string input = Console.ReadLine();
                bool hasNonLetter = false;

                if (!string.IsNullOrEmpty(input))
                {
                    for (int i = 0; i < input.Length; i++)
                    {

                        if (!char.IsLetter(input[i]))
                        {
                            hasNonLetter = true;
                            break;
                        }
                    }

                    if (hasNonLetter)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\nYour name has a non alphabet character. Try again.\n");
                        Console.ResetColor();
                    }
                    else
                    {
                        return input;
                    }

                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nYou didn't enter a your name. Try again.");
                    Console.ResetColor();
                }
            }
        }

        static int SelectGameMode(string prompt)
        {
            while (true)
            {
                Console.Write(prompt);
                string input = Console.ReadLine();

                if (int.TryParse(input, out int number))
                {
                    if (number >= 1 && number <= 3)
                    {
                        return number;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\nThat's not a game mode.\n");
                        Console.ResetColor();
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nYou didn't enter a number. Try again.");
                    Console.ResetColor();
                }
            }
        }

        static void PlayGuessingGame(string playerName, int gameMode)
        {
            int theAnswer = 0;
            int guessCount = 0;
            int playerGuess;
            int attempts = 0;
            string playerInput;
            bool isEasyMode = false;
            bool isNormalMode = false;
            bool isHardMode = false;
            bool isWinner = false;

            Random r = new Random();

            if (gameMode == 1)
            {
                theAnswer = r.Next(1, 6);
                isEasyMode = true;
                attempts = 3;
                Console.WriteLine("\n****************************************");
                Console.WriteLine($"\n{playerName}, you have selected Easy Mode.\n\nSelect a number between 1 and 5.\n\nEnter Q to QUIT at any time.");
                Console.WriteLine($"\nYou have {attempts} guesses to win.");
                Console.WriteLine("\n****************************************");
            }
            else if (gameMode == 2)
            {
                theAnswer = r.Next(1, 21);
                isNormalMode = true;
                attempts = 5;
                Console.WriteLine("\n****************************************");
                Console.WriteLine($"\n{playerName}, you have selected Normal Mode.\n\nSelect a number between 1 and 20.\n\nEnter Q to QUIT at any time.");
                Console.WriteLine($"\nYou have {attempts} guesses to win.");
                Console.WriteLine("\n****************************************");
            }
            else if (gameMode == 3)
            {
                theAnswer = r.Next(1, 51);
                isHardMode = true;
                attempts = 8;
                Console.WriteLine("\n****************************************");
                Console.WriteLine($"\n{playerName}, you have selected Hard Mode.\n\nSelect a number between 1 and 50.\n\nEnter Q to QUIT at any time.");
                Console.WriteLine($"\nYou have {attempts} guesses to win.");
                Console.WriteLine("\n****************************************");
            }

            for (int i = 1; i <= attempts; i++)
            {
                // get player input
                Console.Write($"\n{playerName}, guess the number: ");
                playerInput = Console.ReadLine();

                if (playerInput.Equals("Q"))
                {
                    break;
                }

                //attempt to convert the string to a number
                if (int.TryParse(playerInput, out playerGuess))
                {
                    if ((isEasyMode && playerGuess >= 1 && playerGuess <= 5)
                        || (isNormalMode && playerGuess >= 1 && playerGuess <= 20)
                        || (isHardMode && playerGuess >= 1 && playerGuess <= 50))
                    {
                        guessCount++;
                        if (playerGuess == theAnswer)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            if (guessCount == 1)
                            {
                                Console.WriteLine($"\n{playerName}! The answer was {theAnswer}! You guessed on the first try!! YOU HAVE ESP!!!");
                            }
                            else
                            { 
                                Console.WriteLine($"\n{playerName}! {theAnswer} was the number!! YOU WIN!!!");
                                Console.WriteLine($"\nIt only took you {guessCount} tries. LOL");
                            }
                            Console.ResetColor();

                            isWinner = true;

                            break;
                        }
                        else
                        {
                            if (playerGuess > theAnswer)
                            {
                                Console.WriteLine($"\n{playerName}, your guess was too high!");

                                if (attempts - i > 1)
                                {
                                    Console.WriteLine($"\nYou have {attempts - i} guesses left.");
                                }
                                else if (attempts - i == 1)
                                {
                                    Console.WriteLine($"\nYou have {attempts - i} guess left.");
                                }
                            }
                            else
                            {
                                Console.WriteLine($"\n{playerName}, your guess was too low!");


                                if (attempts - i > 1)
                                {
                                    Console.WriteLine($"\nYou have {attempts - i} guesses left.");
                                }
                                else if (attempts - i == 1)
                                {
                                    Console.WriteLine($"\nYou have {attempts - i} guess left.");
                                }
                            }
                        }
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"\n{playerName}, your guess was out of range. Try Again.");
                        Console.ResetColor();
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"\n{playerName}, that wasn't a number! Try Again.");
                    Console.ResetColor();
                }

            }
            if (guessCount == attempts && !isWinner)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine($"\n{playerName}, you ran out of guesses. Better luck next time.");
                Console.ResetColor();
            }
        }

        static bool PlayAgain(string prompt)
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
                    else if(newInput == "n")
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
