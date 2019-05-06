using System;
using System.Text.RegularExpressions;
using System.Text;
using System.Linq;

namespace Warmups.BLL
{
    public class Conditionals
    {
        public bool AreWeInTrouble(bool aSmile, bool bSmile)
        {
            bool inTrouble = false;
            if ((aSmile && bSmile) || (!aSmile && !bSmile))
            {
                inTrouble = true;
            }
            return inTrouble;
        }

        public bool CanSleepIn(bool isWeekday, bool isVacation)
        {
            bool sleepIn = false;

            if (!isWeekday || isVacation)
            {
                sleepIn = true;
            }

            return sleepIn;
        }

        public int SumDouble(int a, int b)
        {
            int sum = 0;
            if (a == b)
            {
                sum = (a + b) * 2;
            }
            else
            {
                sum = a + b;
            }

            return sum;
        }

        public int Diff21(int n)
        {
            int diff = 0;

            if (n > 21)
            {
                diff = Math.Abs(n - 21) * 2;
            }
            else
            {
                diff = Math.Abs(n - 21);
            }

            return diff;
        }

        public bool ParrotTrouble(bool isTalking, int hour)
        {
            bool inTrouble = false;

            if ((isTalking && hour < 7) || (isTalking && hour > 20))
            {
                inTrouble = true;
            }

            return inTrouble;
        }

        public bool Makes10(int a, int b)
        {
            bool makes10 = false;
            int sum = a + b;

            if ((a == 10 || b == 10) || (sum == 10))
            {
                makes10 = true;
            }
            return makes10;
        }

        public bool NearHundred(int n)
        {
            bool isNearHundred = false;
            int range = 10;

            if (Math.Abs(n - 100) <= range || Math.Abs(n - 200) <= range)
            {
                isNearHundred = true;
            }

            return isNearHundred;
        }

        public bool PosNeg(int a, int b, bool negative)
        {
            bool checkNeg = false;

            if ((a < 0 && b > 0) || (a > 0 && b < 0) && !negative)
            {
                checkNeg = true;
            }
            else if (negative)
            {
                checkNeg = true;
            }
            return checkNeg;
        }

        public string NotString(string s)
        {
            if (!string.IsNullOrEmpty(s))
            {
                if (!s.StartsWith("not"))
                {
                    //s = "not " + s.Substring(0); this also works
                    s = s.Insert(0, "not ");
                }
            }
            return s;
        }

        public string MissingChar(string str, int n)
        {
            if (!string.IsNullOrEmpty(str))
            {
                //StringBuilder sb = new StringBuilder(str);
                //sb.Remove(n, 1);
                //str = sb.ToString();

                //using subststring works as well
                string str1 = str.Substring(0, n);
                string str2 = str.Substring(n + 1);
                str = str1 + str2;
            }

            return str;
        }

        public string FrontBack(string str)
        {
            if (!string.IsNullOrEmpty(str))
            {
                //Given a string, return a new string where the first and last chars have been exchanged. 
                if (str.Length > 1)
                {
                    string str1 = str.Substring(0, 1);
                    string str2 = str.Substring(str.Length - 1);
                    str = str.TrimStart(str[0]);
                    str = str.TrimEnd(str[str.Length - 1]);
                    str = str2 + str + str1;
                }
            }
            return str;
        }

        public string Front3(string str)
        {
            if (!string.IsNullOrEmpty(str))
            {
                if (str.Length < 3)
                {
                    str = str.Substring(0, str.Length);
                    str = str + str + str;
                }
                else
                {
                    str = str.Substring(0, 3);
                    str = str + str + str;
                }
            }

            return str;
        }

        public string BackAround(string str)
        {
            if (!string.IsNullOrEmpty(str))
            {
                string back = str.Substring(str.Length - 1);
                str = back + str + back;
            }
            return str;
        }

        public bool Multiple3or5(int number)
        {
            bool isMultiple = false;

            if (number % 3 == 0 || number % 5 == 0)
            {
                isMultiple = true;
            }

            return isMultiple;
        }

        public bool StartHi(string str)
        {
            bool hiStart = false;

            if (!string.IsNullOrEmpty(str))
            {
                bool contains = Regex.IsMatch(str, @"\bhi\b"); //regex expression will match an exact "hi" in the string

                if (str.StartsWith("hi") && contains)
                {
                    hiStart = true;
                }
            }
            return hiStart;
        }

        public bool IcyHot(int temp1, int temp2)
        {
            bool isIcyHot = false;

            if ((temp1 < 0 && temp2 > 100) || (temp2 < 0 && temp1 > 100))
            {
                isIcyHot = true;
            }

            return isIcyHot;
        }

        public bool Between10and20(int a, int b)
        {
            bool isBetween = false;

            if (a >= 10 && a <= 20 || b >= 10 && b <= 20)
            {
                isBetween = true;
            }
            return isBetween;
        }

        public bool HasTeen(int a, int b, int c)
        {
            bool isTeen = false;

            if (a >= 13 && a <= 19
                || b >= 13 && b <= 19
                || c >= 13 && c <= 19)
            {
                isTeen = true;
            }

            return isTeen;
        }

        public bool SoAlone(int a, int b)
        {
            bool isAlone = false;

            if ((a >= 13 && a <= 19) && !(b >= 13 && b <= 19)
               || !(a >= 13 && a <= 19) && (b >= 13 && b <= 19))
            {
                isAlone = true;
            }

            return isAlone;
        }

        public string RemoveDel(string str)
        {
            if (!string.IsNullOrEmpty(str))
            {
                int index = str.IndexOf("del");
                if (index == 1)
                {
                    string str1 = str.Substring(0, 1);
                    str = str.Substring(index + 3);
                    str = str1 + str;
                }
            }
            return str;
        }

        public bool IxStart(string str)
        {
            bool isIx = false;

            if (!string.IsNullOrEmpty(str))
            {
                int index = str.IndexOf("ix");

                if (index == 1)
                {
                    isIx = true;
                }
            }

            return isIx;
        }

        public string StartOz(string str)
        {
            string result = ""; 

            if (str.Length >= 1 && str[0] == 'o')
            {
                result = result + str[0];
            }

            if (str.Length >= 2 && str[1] == 'z')
            {
                result = result + str[1];
            }

            return result;

        }

        public int Max(int a, int b, int c)
        {
            int max = Math.Max(Math.Max(a, b), c);

            return max;
        }

        public int Closer(int a, int b)
        {
            int closestToTen = 0;
            if (Math.Abs(a - 10) == Math.Abs(b - 10))
            {
                return 0;
            }
            else if (Math.Abs(a - 10) > Math.Abs(b - 10))
            {
                closestToTen = b;
            }
            else if (Math.Abs(a - 10) < Math.Abs(b - 10))
            {
                closestToTen = a;
            }

            return closestToTen;
        }

        public bool GotE(string str)
        {
            bool gotE = false;

            int count = str.Count(x => x == 'e');

            //alt answer 1
            int count1 = str.Split('e').Length - 1;

            //alt answer 2
            int count2 = 0;
            foreach (char c in str)
            {
                if (c == 'e') count2++;
            }

            if (count > 0 && count <= 3)
            {
                gotE = true;
            }
            return gotE;
        }

        public string EndUp(string str)
        {
            if (!string.IsNullOrEmpty(str))
            {
                if (str.Length < 3)
                {
                    str = str.ToUpper();
                }
                else
                {
                    string str1 = str.Substring(0, str.Length - 3);
                    string str2 = str.Substring(str.Length - 3);
                    str = str1 + str2.ToUpper();

                    // Alternative Solution converting the string to a char[] and then creating a new string
                    //char[] cArr = str.ToCharArray();
                    //cArr[cArr.Length - 3] = char.ToUpper(cArr[cArr.Length - 3]);
                    //cArr[cArr.Length - 2] = char.ToUpper(cArr[cArr.Length - 2]);
                    //cArr[cArr.Length - 1] = char.ToUpper(cArr[cArr.Length - 1]);
                    //newString = new string(cArr);
                }
            }
            return str;
        }

        public string EveryNth(string str, int n)
        {
            if (!string.IsNullOrEmpty(str))
            {
                StringBuilder sb = new StringBuilder();
                char[] chArr = str.ToCharArray();
                for (int i = 0; i < chArr.Length; i++)
                {
                    if ((i % n) == 0)
                    {
                        sb = sb.Append(chArr[i].ToString());
                    }
                }
                str = sb.ToString();
            }
            return str;
        }
    }
}
