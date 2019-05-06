using System;

namespace Warmups.BLL
{
    public class Strings
    {

        public string SayHi(string name)
        {
            return "Hello " + name + "!";
        }

        public string Abba(string a, string b)
        {
            return a + b + b + a;
        }

        public string MakeTags(string tag, string content)
        {
            if (!string.IsNullOrEmpty(tag) && !string.IsNullOrEmpty(content))
            {
                string front = "<" + tag + ">";
                string back = "</" + tag + ">";
                content = front + content + back;
            }

            return content;
        }

        public string InsertWord(string container, string word)
        {
            if (!string.IsNullOrEmpty(container) && !string.IsNullOrEmpty(word))
            {
                string cut1 = container.Substring(0, 2);
                string cut2 = container.Substring(2);
                word = cut1 + word + cut2;
            }
            return word;
        }

        public string MultipleEndings(string str)
        {
            if (!string.IsNullOrEmpty(str))
            {
                str = str.Substring(str.Length - 2);
                str = str + str + str;
            }
            return str;
        }

        public string FirstHalf(string str)
        {
            if (!string.IsNullOrEmpty(str))
            {
                str = str.Substring(0, str.Length / 2);
            }
            return str;
        }

        public string TrimOne(string str)
        {
            if (!string.IsNullOrEmpty(str))
            {
                str = str.TrimStart(str[0]);
                str = str.TrimEnd(str[str.Length - 1]);
            }
            return str;
        }

        public string LongInMiddle(string a, string b)
        {
            string newString = "";

            if (!string.IsNullOrEmpty(a) && !string.IsNullOrEmpty(b))
            {
                if (a.Length > b.Length)
                {
                    newString = b + a + b;
                }
                else
                {
                    newString = a + b + a;
                }
            }
            return newString;
        }

        public string RotateLeft2(string str)
        {
            if (!string.IsNullOrEmpty(str))
            {
                string str1 = str.Substring(0, 2); //clip the string starting from the beginning with a length of 2
                string str2 = str.Substring(2); //clip the first two charactes of original string       
                str = str2 + str1;
            }
            return str;
        }

        public string RotateRight2(string str)
        {
            if (!string.IsNullOrEmpty(str))
            {
                string str1 = str.Substring(str.Length - 2, 2); //clip the string starting with the second to last character with a lenght of 2
                string str2 = str.Substring(0, str.Length - 2); //clip the string starting from the beginning ending at the second to last character        
                str = str1 + str2;
            }
            return str;
        }

        public string TakeOne(string str, bool fromFront)
        {
            if (!string.IsNullOrEmpty(str))
            {
                if (fromFront)
                {
                    str = str.Substring(0, 1);
                }
                else
                {
                    str = str.Substring(str.Length - 1);
                }
            }
            return str;
        }

        public string MiddleTwo(string str)
        {
            if (!string.IsNullOrEmpty(str))
            {
                if (str.Length % 2 == 0)//check if string is even
                {
                    //divide string by 2 then subtract 1 then choose the length, which is at least 2 and achieved with the Math.min method.
                    str = str.Substring((str.Length / 2) - 1, Math.Min(str.Length, 2));
                }
                else
                {
                    str = str.Substring((str.Length / 2), Math.Min(str.Length, 1));
                }
            }
            return str;
        }

        public bool EndsWithLy(string str)
        {
            bool endsWithLy = false;
            if (!string.IsNullOrEmpty(str))
            {
                if (str.Length == 1)
                {
                    return endsWithLy;
                }
                else if (str.EndsWith("ly"))
                {
                    endsWithLy = true;
                }

            }
            return endsWithLy;
        }

        public string FrontAndBack(string str, int n)
        {
            if (!string.IsNullOrEmpty(str))
            {
                string front = str.Substring(0, n);
                string back = str.Substring(str.Length - n);
                str = front + back;
            }
            return str;
        }

        public string TakeTwoFromPosition(string str, int n)
        {
            if (!string.IsNullOrEmpty(str))
            {
                int length = 2;
                if (n > length || n < length)
                {
                    str = str.Substring(0, 2);
                }
                else
                {
                    str = str.Substring(n, 2);
                }

            }
            return str;
        }

        public bool HasBad(string str)
        {
            bool isBad = false;

            if (!string.IsNullOrEmpty(str))
            {
                if (str.IndexOf("bad") == 0 || str.IndexOf("bad") == 1)
                {
                    isBad = true;
                }
            }
            return isBad;
        }

        public string AtFirst(string str)
        {
            //if (str.Length == 0) return "@@";
            //if (str.Length == 1) return str + "@";
            //return str.Substring(0, 2);

            if (str.Length == 0)
            {
                return "@@";
            }
            else if (str.Length == 1)
            {
                return str + "@";
            }
            else
            {
                return str.Substring(0, 2);
            }
        }

        public string LastChars(string a, string b)
        {
            if (a.Length == 0 && b.Length != 0)
            {
                return "@" + "" + b[b.Length - 1];
            }
            if (b.Length == 0 && a.Length != 0)
            {
                return a[0] + "@";
            }
            if (a.Length == 0 && b.Length == 0)
            {
                return "@@";
            }
            return a[0] + "" + b[b.Length - 1];
        }

        public string ConCat(string a, string b)
        {
            if (!string.IsNullOrEmpty(a) && !string.IsNullOrEmpty(b))
            {
                if (a[a.Length - 1].Equals(b[0]))
                {
                    a = a.TrimEnd(a[a.Length - 1]);
                }
            }
            return a + b;
        }

        public string SwapLast(string str)
        {
            string newString = "";
            if (!string.IsNullOrEmpty(str))
            {
                if (str.Length > 1)
                {
                    char[] array = str.ToCharArray(); // Get characters
                    char temp = array[array.Length - 1]; // Get "temporary copy of last character"
                    array[array.Length - 1] = array[array.Length - 2]; // Assign the second to last element to the last element
                    array[array.Length - 2] = temp; // Assign "temporary copy of last character" to the second to last element
                    newString = new string(array); // 
                    return newString;
                }
                return str;
            }
            return newString;
        }

        public bool FrontAgain(string str)
        {
            bool isFrontAndBack = false;

            if (str[0].Equals(str[str.Length - 2]) &&
                str[1].Equals(str[str.Length - 1]))
            {
                isFrontAndBack = true;
            }
            return isFrontAndBack;
        }

        public string MinCat(string a, string b)
        {
            int aLength = a.Length;
            int bLength = b.Length;

            if (aLength > bLength)
            {
                aLength = aLength - bLength;
                a = a.Substring(aLength);
            }
            else if (aLength < bLength)
            {
                bLength = bLength - aLength;
                b = b.Substring(bLength);
            }

            return a + b;
        }

        public string TweakFront(string str)
        {
            if (!string.IsNullOrEmpty(str))
            {
                string firstLetter = str[0].ToString().ToLower();
                string secondLetter = str[1].ToString().ToLower();

                if (firstLetter == "a" && secondLetter == "b")
                {
                    return str;
                }
                else if (firstLetter == "a" && secondLetter != "b")
                {
                    str = str.Remove(1, 1);
                }
                else if (firstLetter != "a" && secondLetter == "b")
                {
                    str = str.Remove(0, 1);
                }
                else
                {
                    str = str.Substring(str.Length - 3);
                }
            }
            return str;
        }

        public string StripX(string str)
        {
            if (!string.IsNullOrEmpty(str))
            {
                char firstLower = str[0];
                string firstLetter = firstLower.ToString();
                firstLetter = firstLetter.ToLower();

                char last = str[str.Length - 1];
                string lastLetter = last.ToString();

                if (firstLetter.Equals("x") || lastLetter.Equals("x"))
                {
                    if (str[0].Equals('X'))
                    {
                        str = char.ToLower(str[0]) + str.Substring(1);
                    }

                    str = str.TrimStart('x');
                    str = str.TrimEnd('x');
                }
            }
            return str;
        }
    }
}
