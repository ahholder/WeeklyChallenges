using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet06
    {
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
        {
            //throw new NotImplementedException();
            if (words == null) return false;
            string[] collection = words.ToArray();
            if (collection.Length < 1) return false;
            //string placeholder = "";
            bool result = false; 
            if (ignoreCase == true)
            {
                for (int i = 0; i<collection.Length;i++)
                {
                    if (collection[i] != null && collection[i].ToLower() == word.ToLower())
                    {
                        result = true;
                    }
                }
            } else
            {
                for (int i = 0; i < collection.Length; i++)
                {
                    if (collection[i] != null && collection[i] == word)
                    {
                        result = true;
                    }
                }
            }
         return result;
        }

        public bool IsPrimeNumber(int num)
        {
            //throw new NotImplementedException();
            if (num == null) return false;
            bool result = true;
            if (num > -1)
            {
                for (int i = num; i > 0; i--)
                {
                    if (num % i == 0 && i != 1 && i != num) result = false;
                }
            } else
            {
                for (int i = num; i < 0; i++)
                {
                    if (num % i == 0 && i != 1 && i != num) result = false;
                }
            }
            if (num == 1 || num == -1 || num == 0) result = false;
            return result;
        }

        public int IndexOfLastUniqueLetter(string str)
        {
            //throw new NotImplementedException();
            int index = -1;
            bool legit = true;
            if (str == "") return index;
            for (int i = 0; i < str.Length; i++)
            {
                legit = true;
                for (int i2 = 0; i2 < str.Length; i2++)
                {
                    if (i != i2 && str[i] == str[i2]) legit = false;
                }
                if (legit == true) index = i;
            }
            return index;
        }

        public int MaxConsecutiveCount(int[] numbers)
        {
            //throw new NotImplementedException();
            int index = 0;
            bool legit = true;
            int record = 0;
            if (numbers == null) return 0;
            for (int i = 0; i < numbers.Count(); i++)
            {
                index = 0;
                legit = true;
                for (int i2 = i; i2 < numbers.Count(); i2++)
                {
                    if (numbers[i] == numbers[i2] && legit == true)
                    //if (numbers[i] == numbers[i2])
                    {
                        index += 1;
                    } else
                    {
                        legit = false;
                    }
                }
                if (index > record) record = index;
            }
            return record;
        }

        public double[] GetEveryNthElement(List<double> elements, int n)
        {
            //throw new NotImplementedException();
            var collection = new List<double>();
            if (elements == null) return collection.ToArray();
            double[] list = elements.ToArray();
            if (list.Length < 1 || n < 0) return collection.ToArray();
            int tracker = 0;
            int mod = n;
            //if (mod < 0) mod *= -1;
            for (int i = 0; i < list.Length; i++)
            {
                tracker += 1;
                if (tracker % mod == 0) collection.Add(list[i]);
            }
            return collection.ToArray();
        }
    }
}
