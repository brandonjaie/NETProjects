using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warmups.BLL
{
    public class Logic
    {

        public bool GreatParty(int cigars, bool isWeekend)
        {
            //if (isWeekend)
            //{
            //    if (cigars >= 40)
            //    {
            //        return true;
            //    }
            //}
            //if (!isWeekend)
            //{
            //    if (cigars >= 40 && cigars <= 60)
            //    {
            //        return true;
            //    }
            //}
            //return false;
            return cigars >= 40 && (cigars <= 60 || isWeekend);
        }
        
        public int CanHazTable(int yourStyle, int dateStyle)
        {
            int no = 0;
            int maybe = 1;
            int yes = 2;

            if (yourStyle <= 2 || dateStyle <= 2)
            {
                return no;
            }
            else if (yourStyle >= 8 || dateStyle >= 8)
            {
                return yes;
            }
            return maybe;
        }

        public bool PlayOutside(int temp, bool isSummer)
        {
            if (isSummer && (temp >= 60 && temp <= 100))
            {
                return true;
            }
            else if (!isSummer && (temp >= 60 && temp <= 90))
            {
                return true;
            }
            return false;
        }
        
        public int CaughtSpeeding(int speed, bool isBirthday)
        {
            int noTicket = 0;
            int smallTicket = 1;
            int bigTicket = 2;

            if (isBirthday)
            {
                if (speed > 65 && speed <= 85)
                {
                    return smallTicket;
                }
                else if (speed >= 86)
                {
                    return bigTicket;
                }

            }
            else if (!isBirthday)
            {
                if (speed > 60 && speed <= 80)
                {
                    return smallTicket;
                }
                else if (speed >= 81)
                {
                    return bigTicket;
                }
            }

            return noTicket;
        }
        
        public int SkipSum(int a, int b)
        {
            int sum = a + b;

            if (sum >= 10 && sum <= 19)
            {
                return 20;
            }

            return sum;
        }
        
        public string AlarmClock(int day, bool vacation)
        {
            if (vacation)
            {
                if (day >= 1 && day <= 5)
                {
                    return "10:00";
                }
                else
                {
                    return "off";
                }
            }
            else if (!vacation)
            {
                if (day >= 1 && day <= 5)
                {
                    return "7:00";
                }
                else
                {
                    return "10:00";
                }
            }

            return "Alarm Clock is Broken";

            /* Solution w/Ternary Operator */
            //if (vacation) return (day >= 1 && day <= 5) ? "10:00" : "off";
            //return (day >= 1 && day <= 5) ? "7:00" : "10:00";
        }

        public bool LoveSix(int a, int b)
        {
            int sum = a + b;
            int diff = Math.Abs(a - b);

            if (a == 6 || b == 6 || sum == 6 || diff == 6)
            {
                return true;
            }

            return false;

            /* Alternate way to present solution */
            //return a == 6 || b == 6 || a + b == 6 || Math.Abs(a - b) == 6;
        }

        public bool InRange(int n, bool outsideMode)
        {
            if (!outsideMode)
            {
                if (n >= 1 && n <= 10)
                {
                    return true;
                }
            }
            else
            {
                if (n <= 1 || n >= 10)
                {
                    return true;
                }
            }

            return false;
        }
        
        public bool SpecialEleven(int n)
        {
            if (n % 11 == 0 || n % 11 == 1)
            {
                return true;
            }

            return false;
        }
        
        public bool Mod20(int n)
        {
            if (n % 20 == 1 || n % 20 == 2)
            {
                return true;
            }
            return false;
        }
        
        public bool Mod35(int n)
        {
            if (n % 3 == 0 && !(n % 5 == 0)
    || n % 5 == 0 && !(n % 3 == 0))
            {
                return true;
            }
            return false;
        }
        
        public bool AnswerCell(bool isMorning, bool isMom, bool isAsleep)
        {
            if (!isAsleep)
            {
                if (isMorning)
                {
                    return false;
                }
                else if (isMorning && isMom)
                {
                    return true;
                }
                else
                {
                    return true;
                }
            }
            return false;
        }
        
        public bool TwoIsOne(int a, int b, int c)
        {
            if (a + b == c || a + c == b || b + c == a)
            {
                return true;
            }

            return false;
        }
        
        public bool AreInOrder(int a, int b, int c, bool bOk)
        {
            if (!bOk)
            {
                if (b > a && b < c)
                {
                    return true;
                }
            }
            else
            {
                if (a < c)
                {
                    return true;
                }
            }

            return false;
        }
        
        public bool InOrderEqual(int a, int b, int c, bool equalOk)
        {
            if (equalOk)
            {
                if (a <= b && b <= c)
                {
                    return true;
                }
            }
            else if (a < b && b < c)
            {
                return true;
            }
            return false;
        }
        
        public bool LastDigit(int a, int b, int c)
        {
            int modA = a % 10;
            int modB = b % 10;
            int modC = c % 10;

            if (modA == modB || modB == modC || modA == modC)
            {
                return true;
            }

            return false;
        }
        
        public int RollDice(int die1, int die2, bool noDoubles)
        {
            if (noDoubles)
            {
                if (die1 == 6 && die2 == 6)
                {
                    die1 = 1;
                }
                else if (die1 == die2)
                {
                    die1++;
                }
            }

            return die1 + die2;
        }

    }
}
