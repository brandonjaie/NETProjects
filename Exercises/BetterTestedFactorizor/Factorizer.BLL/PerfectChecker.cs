using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorizer.BLL
{
    public class PerfectChecker
    {
        public bool IsPerfectNumber(int number)
        {
            int sum = 0;
            bool isPerfect = false;

            for (int i = 1; i < number; i++)
            {
                if (number % i == 0)
                {
                    sum += i;
                }
            }

            if (sum == number)
            {
                isPerfect = true;
            }

            return isPerfect;

        }
    }
}
