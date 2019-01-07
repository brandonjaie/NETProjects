using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorizer.BLL
{
    public class FactorFinder
    {
        public List<int> GetFactors(int number)
        {
            List<int> factors = new List<int>();

            if (number == 0)
            {
                factors.Add(0);
                return factors;
            }

            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                {
                    factors.Add(i);
                }
            }

            return factors;
        }

        public int[] GetFactors2(int number)
        {
            if (number == 0)
                return new int[] { 0 };

            List<int> factors = new List<int>();

            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                {
                    factors.Add(i);
                }
            }

            return factors.ToArray();
        }
    }
}
