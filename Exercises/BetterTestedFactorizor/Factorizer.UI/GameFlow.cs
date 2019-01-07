using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Factorizer.BLL;

namespace Factorizer.UI
{
    public class GameFlow
    {
        public void PlayFactorizer()
        {
            ConsoleOutput.DisplayTitle();

            while (true)
            {
                int number;
                number = ConsoleInput.GetIntFromUser();
                ConsoleOutput.DisplayFactors(number);
                ConsoleOutput.DisplayPrimeNumber(number);
                ConsoleOutput.DisplayPerfectNumber(number);

                bool isPlaying = ConsoleInput.PlayAgain();

                if (!isPlaying)
                {
                    break;
                }
            }

            ConsoleOutput.DisplayEndTitle();
        }

    }
}
