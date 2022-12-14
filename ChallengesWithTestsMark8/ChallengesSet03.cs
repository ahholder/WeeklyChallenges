using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Runtime.Versioning;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            //throw new NotImplementedException();
            int set = vals.Length;
            bool result = false;
            for (int i = 0; i < set; i++)
            {
                if (vals[i] == false)
                {
                    result = true;
                }
            }
            return result;
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            if (numbers == null) return false;
            if (numbers.Count() < 1) return false;
            var list = numbers.GetEnumerator();
            list.Reset();
            int tally = numbers.Count();
            var result = 0;
            for (int i = 0; i < tally; i++)
            {
                list.MoveNext();
                if (list.Current % 2 != 0)
                {
                    result += list.Current;
                }
            }
            if (result % 2 != 0) return true;
            return false;
            //throw new NotImplementedException();
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            //throw new NotImplementedException();
            bool up = false;
            bool low = false;
            bool num = false;
            int tally = password.Length;
            for (int i = 0; i < tally; i++)
            {
                if (password[i] == '1' || password[i] == '2' || password[i] == '3' || password[i] == '4' || password[i] == '5' || password[i] == '6' || password[i] == '7' || password[i] == '8' || password[i] == '9' || password[i] == '0')
                {
                    num = true;
                }
                else
                {
                    if ((password[i].ToString()).ToLower() == password[i].ToString()) low = true;
                    if ((password[i].ToString()).ToUpper() == password[i].ToString()) up = true;
                }
            }
            if (up == true && low == true && num == true)
            {
                return true;
            } else
            {
                return false;
            }
        }

        public char GetFirstLetterOfString(string val)
        {
            //throw new NotImplementedException();
            //if (val == null) return "";
            return val[0];

        }

        public char GetLastLetterOfString(string val)
        {
            //throw new NotImplementedException();
            return val[val.Length - 1];
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            //throw new NotImplementedException();
            if (divisor == 0) return 0;
            return dividend / divisor;
        }

        public int LastMinusFirst(int[] nums)
        {
            //throw new NotImplementedException();
            return nums[nums.Length - 1] - nums[0];
        }

        public int[] GetOddsBelow100()
        {
            //throw new NotImplementedException();
            /*var numbers = new List<int>();
            int tally = 0;
            for (int i=99;i>=0;i--)
            {
                if (i % 2 != 0)
                {
                    numbers.Add(i);
                }
            }
            return numbers.ToArray();*/
            var numbers = new List<int>();
            for (int i = 0; i <= 100; i++)
            {
                if (i % 2 != 0)
                {
                    numbers.Add(i);
                }
            }
            return numbers.ToArray();
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            //throw new NotImplementedException();

            var closing = "";
            var tally = words.Count();
            for (int i = 0; i < tally; i++)
            {
                words[i] = words[i].ToUpper();
                Console.WriteLine(words[i]);
            }
            /*foreach (var thing in words)
            {
                if (closing != "")
                {
                    closing += ", ";
                }
                closing += thing.ToUpper();
            }
            Console.WriteLine(closing);*/

            /*foreach (var thing in words)
            {
                Console.WriteLine(thing.ToUpper());
                //closing = thing.ToUpper();
            }*/
        }
    }
}
