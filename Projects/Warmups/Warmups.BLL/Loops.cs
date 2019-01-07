using System;
using System.Text;

namespace Warmups.BLL
{
    public class Loops
    {

        public string StringTimes(string str, int n)
        {
            if (!string.IsNullOrEmpty(str))
            {
                //StringBuilder sb = new StringBuilder(str.Length * n);
                //for (int i = 0; i < n; i++)
                //{
                //    sb.Append(str);
                //}
                //str = sb.ToString();

                /*Simple solution w/o String Builder*/
                String s = "";
                for (int i = 0; i < n; i++)
                {
                    s = s + str;
                }
                return s;
            }
            return str;
        }

        public string FrontTimes(string str, int n)
        {
            if (!string.IsNullOrEmpty(str))
            {
                StringBuilder sb = new StringBuilder(str.Length * n);
                for (int i = 0; i < n; i++)
                {
                    str = str.Substring(0, 3);
                    sb.Append(str);
                }
                str = sb.ToString();
            }
            return str;
        }

        public int CountXX(string str)
        {
            int count = 0;

            if (!string.IsNullOrEmpty(str))
            {
                string pattern = "xx";
                //While Loop solution
                /*int i = 0;
                while ((i = str.IndexOf(pattern, i)) != -1)
                {
                    //i += pattern.Length; //to stop overlapping
                    i++;
                    count++;
                }*/

                for (int i = 0; (i = str.IndexOf(pattern, i)) != -1; i++)
                {
                    count++;
                }
            }
            return count;
        }

        public bool DoubleX(string str)
        {
            bool isDoubleX = false;

            if (!string.IsNullOrEmpty(str))
            {
                string pattern = "x";
                int index = str.IndexOf(pattern);
                for (int i = 0; (i = str.IndexOf(pattern, i)) != -1; i++)
                {
                    if (i == index + 1)
                    {
                        isDoubleX = true;
                    }
                }
            }
            return isDoubleX;
        }

        public string EveryOther(string str)
        {
            if (!string.IsNullOrEmpty(str))
            {
                StringBuilder sb = new StringBuilder();
                char[] cArr = str.ToCharArray();
                for (int i = 0; i < cArr.Length; i++)
                {
                    if (i % 2 == 0)
                    {
                        sb = sb.Append(cArr[i].ToString());
                    }
                }
                str = sb.ToString();
            }
            return str;
        }

        public string StringSplosion(string str)
        {
            if (!string.IsNullOrEmpty(str))
            {

                StringBuilder sb = new StringBuilder();
                char[] cArr = str.ToCharArray();

                for (int i = 0; i < cArr.Length; i++)
                {
                    for (int j = 0; j <= i; j++)
                    {
                        sb = sb.Append(cArr[j].ToString());
                    }
                }
                str = sb.ToString();

                //The outer loop runs "The Length of the char[]" times. 
                //In each iteration of outer loop, the inner loop runs i times. 
                //Notice that, the value of "i" is different for every iteration of outer loop.
                //The inner loop runs only once in first iteration of outer loop, 
                //twice in second iteration of outer loop and so on until i is incremented to 
                //The Length of the char[]. When i equals "The Length of the char[]", the loop terminates.

                /* Simple Solution w/o nested for loop and string builder */
                //String result = "";
                //for (int i = 0; i < str.Length; i++)
                //{
                //    result += str.Substring(0, i + 1);
                //}
                // return result;
            }
            return str;
        }

        public int CountLast2(string str)
        {
            int count = 0;

            if (!string.IsNullOrEmpty(str))
            {
                string pattern = str.Substring(str.Length - 2);
                str = str.Substring(0, str.Length - 2);

                for (int i = 0; (i = str.IndexOf(pattern, i)) != -1; i++)
                {
                    count++;
                }
            }

            return count;
        }

        public int Count9(int[] numbers)
        {
            int count = 0;

            foreach (int num in numbers)
            {
                if (num == 9)
                {
                    count++;
                }
            }

            /* Solution with for loop */
            //int length = numbers.Length;
            //for (int i = 0; i <= numbers.Length - 1; i++)
            //{
            //    if (numbers[i] == 9)
            //    {
            //        count++;
            //    }
            //}
            return count;
        }

        public bool ArrayFront9(int[] numbers)
        {
            bool checkForNine = false;
            int searchInt = 9;
            int index = Array.IndexOf(numbers, searchInt);

            for (int i = 0; i < numbers.Length; i++)
            {
                if (i <= 3 && numbers[i] == 9)
                {
                    checkForNine = true;
                }
            }


            return checkForNine;
        }

        public bool Array123(int[] numbers)
        {
            bool check123 = false;
            int[] pattern = { 1, 2, 3 };
            int firstMatchFoundAtIndex = 0;

            for (int i = 0; i <= numbers.Length - pattern.Length; i++)
            {
                //if beginning elements match we start comparing
                if (numbers[i] == pattern[0])
                {
                    //search element by element for match to the pattern
                    int match = 0;
                    for (int j = 0; j < pattern.Length; j++)
                    {
                        if (pattern[j] != numbers[i + j])
                        {
                            break;
                        }
                        match++;
                    }
                    //patterns match
                    if (match == pattern.Length)
                    {
                        firstMatchFoundAtIndex = i;
                        check123 = true;
                    }
                }
            }

            /* Simple solution */
            //for (int i = 0; i < numbers.length - 2; i++)
            //{
            //    if ((numbers[i] == 1) && (numbers[i + 1] == 2) && (numbers[i + 2] == 3))
            //    {
            //        check123 = true;
            //    }

            //}


            /* LINQ Solution */
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers.Skip(i).Take(pattern.Length).SequenceEqual(pattern))
            //    {
            //        check123 = true;
            //    }
            //}


            return check123;
        }

        public int SubStringMatch(string a, string b)
        {
            int positionCount = 0;
            string checkStrA = "";
            string checkStrB = "";

            for (int i = 0; i < a.Length - 1; i++)
            {
                checkStrA = a.Substring(i, 2);

                for (int j = 0; j < b.Length - 1; j++)
                {
                    checkStrB = b.Substring(j, 2);
                    if (checkStrA == checkStrB)
                    {
                        positionCount++;
                    }
                }
            }

            return positionCount;
        }

        public string StringX(string str)
        {
            string newstr = "";
            //char[] cArr = str.ToCharArray();
            for (int i = 1; i < str.Length - 1; i++)
            {
                if (str[i] != 'x')
                {
                    newstr += str[i];
                }
            }
            return str[0] + newstr + str[str.Length - 1];
        }

        public string AltPairs(string str)
        {
            string newStr = "";
            // Run i by 4 to hit 0, 4, 8, ...
            for (int i = 0; i < str.Length; i += 4)
            {
                newStr += str[i];
                if (i + 1 < str.Length)
                {
                    newStr += str[i + 1];
                }
            }

            return newStr;
        }

        public string DoNotYak(string str)
        {
            string pattern = "yak";
            int index = str.IndexOf("yak");

            /* Solution using Ternay Operator */
            int index2 = str.IndexOf(pattern);
            string newString = (index < 0)
                ? str
                : str.Remove(index, pattern.Length);

            return newString;

            /* Same as above just written out */
            //if (index < 0)
            //{
            //    return str;
            //}
            //else
            //{
            //    return str = str.Remove(index, pattern.Length);
            //}

            /* Solution using For Loop */
            //for (int i = 0; i < str.Length - 2; i++)
            //{
            //    if (str[i] == 'y')
            //    {
            //        if (str[i + 2] == 'k') // skip the "a" and check next element for "k"
            //        {
            //            str = str.Remove(i, 3); // starting at the index, remove three characters
            //        }
            //    }
            //}
            //return str;
        }

        public int Array667(int[] numbers)
        {
            int count = 0;

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] == 6 && (numbers[i + 1] == 6 || numbers[i + 1] == 7))
                {
                    count++;
                }
            }

            return count;
        }

        public bool NoTriples(int[] numbers)
        {
            for (int i = 0; i < numbers.Length - 2; i++)
            {
                if (numbers[i] == numbers[i + 1] && numbers[i] == numbers[i + 2])
                {
                    return false;
                }
            }

            return true;
        }

        public bool Pattern51(int[] n)
        {
            if (n.Length >= 3)
            {
                for (int i = 0; i < n.Length - 1; i++)
                {
                    int x = n[i];
                    if (n[i + 1] == x + 5 && n[i + 2] == x - 1)
                    {
                        return true;
                    }
                }
            }

            return false;
        }

    }
}
