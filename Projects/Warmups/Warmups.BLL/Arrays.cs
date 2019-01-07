using System;
using System.Collections.Generic;
using System.Linq;

namespace Warmups.BLL
{
    public class Arrays
    {

        public bool FirstLast6(int[] numbers)
        {

            if (numbers[0] == 6 || numbers[numbers.Length - 1] == 6)
            {
                return true;
            }

            return false;
        }

        public bool SameFirstLast(int[] numbers)
        {
            if (numbers.Length > 1 && numbers[0] == numbers[numbers.Length - 1])
            {
                return true;
            }

            return false;
        }
        public int[] MakePi(int n)
        {
            double pi = Math.PI;
            string str = pi.ToString().Remove(1, 1);
            char[] charArr = str.ToCharArray();
            int[] madePi = new int[n];

            for (int i = 0; i < n; i++)
            {
                madePi[i] = int.Parse(charArr[i].ToString());
            }
            return madePi;
        }

        public bool CommonEnd(int[] a, int[] b)
        {
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < b.Length; j++)
                {
                    if (a[0] == b[0] || a[a.Length - 1] == b[b.Length - 1])
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public int Sum(int[] numbers)
        {
            /* solution with for loop */
            int sum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }

            return sum;

            //return numbers.Sum();
        }

        public int[] RotateLeft(int[] numbers)
        {
            int[] rotateLeftArray = new int[numbers.Length];

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                rotateLeftArray[i] = numbers[i + 1];
            }

            rotateLeftArray[rotateLeftArray.Length - 1] = numbers[0];

            return rotateLeftArray;


            /* Rotate Array Right */
            //int[] rotateRightArray = new int[numbers.Length];

            //for (int i = 1; i < numbers.Length; i++)
            //{
            //    rotateRightArray[i] = numbers[i - 1];
            //}

            //rotateRightArray[0] = numbers[rotateRightArray.Length - 1];

            //return rotateRightArray;
        }

        public int[] Reverse(int[] numbers)
        {
            for (int i = 0; i < numbers.Length / 2; i++)
            {
                int tmp = numbers[i];
                numbers[i] = numbers[numbers.Length - i - 1];
                numbers[numbers.Length - i - 1] = tmp;
            }
            return numbers;
        }

        public int[] HigherWins(int[] numbers)
        {
            int[] newArr = new int[numbers.Length];

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[0] >= numbers[numbers.Length - 1])
                {
                    newArr[i] += numbers[0];
                }
                else if (numbers[0] <= numbers[numbers.Length - 1])
                {
                    newArr[i] += numbers[numbers.Length - 1];
                }
            }

            return newArr;
        }

        public int[] GetMiddle(int[] a, int[] b)
        {
            int[] newArr = new int[2];

            if (a.Length == 3 && b.Length == 3)
            {
                for (int i = 0; i < a.Length / 2; i++)
                {
                    newArr[i] = a[1];
                    for (int j = 0; j < b.Length / 2; j++)
                    {
                        newArr[j + 1] = b[1];
                    }
                }
            }
            return newArr;
        }

        public bool HasEven(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    return true;
                }
            }
            return false;
        }

        public int[] KeepLast(int[] numbers)
        {
            int[] newArr = new int[numbers.Length * 2];

            for (int i = 0; i < numbers.Length; i++)
            {
                if (i == numbers.Length - 1)
                {
                    newArr[newArr.Length - 1] = numbers[numbers.Length - 1];
                }
            }

            return newArr;
        }

        public bool Double23(int[] numbers)
        {
            //Dictionary<int, int> newDict = new Dictionary<int, int>();
            int count2 = 0;
            int count3 = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == 2)
                {
                    count2++;
                }

                if (numbers[i] == 3)
                {
                    count3++;
                }
            }

            if (count2 == 2 || count3 == 2)
            {
                return true;
            }
            return false;
        }

        public int[] Fix23(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == 2 && numbers[i + 1] == 3)
                {
                    numbers[i + 1] = 0;
                }
            }

            return numbers;
        }

        public bool Unlucky1(int[] numbers)
        {
            if (numbers[0] == 1 && numbers[1] == 3
    || numbers[1] == 1 && numbers[2] == 3
    || numbers[numbers.Length - 2] == 1 && numbers[numbers.Length - 1] == 3
    || numbers[numbers.Length - 3] == 1 && numbers[numbers.Length - 2] == 3)
            {
                return true;
            }
            return false;
        }

        public int[] Make2(int[] a, int[] b)
        {
            int[] newArr = new int[2];

            if (a.Length == 0)
            {
                newArr[0] = b[0];
                newArr[1] = b[1];
            }
            else if (a.Length == 1)
            {
                newArr[0] = a[0];
                newArr[1] = b[0];
            }
            else if (a.Length >= 2)
            {
                newArr[0] = a[0];
                newArr[1] = a[1];
            }
            return newArr;
        }

    }
}
