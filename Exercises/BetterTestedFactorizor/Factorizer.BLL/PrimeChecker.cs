using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorizer.BLL
{
    public class PrimeChecker
    {

        public bool IsPrimeNumber(int number)
        {
            int totalFactors = 0;
            bool isPrime = false;

            for (int i = 1; i < number; i++)
            {
                if (number % i == 0)
                {
                    totalFactors++;
                }
            }

            if (totalFactors == 1)
            {
                isPrime = true;
            }

            return isPrime;

        }

    }
}
