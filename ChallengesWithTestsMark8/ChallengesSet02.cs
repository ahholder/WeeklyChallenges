using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            //throw new NotImplementedException();
            var tested = c.ToString();
            tested = tested.ToLower();
            bool result = true;
            /*var tested = c;
            char d;
            bool result = char.TryParse(tested, out d);
            if (int.TryParse(tested, out int i) == true || double.TryParse(tested, out double i2) == true || real.TryParse(tested, out double i3) == true)
            {
                result = false;
            }
            return result;*/
            switch (tested)
            {
                case "a":
                    break;
                case "b":
                    break;
                case "c":
                    break;
                case "d":
                    break;
                case "e":
                    break;
                case "f":
                    break;
                case "g":
                    break;
                case "h":
                    break;
                case "i":
                    break;
                case "j":
                    break;
                case "k":
                    break;
                case "l":
                    break;
                case "m":
                    break;
                case "n":
                    break;
                case "o":
                    break;
                case "p":
                    break;
                case "q":
                    break;
                case "r":
                    break;
                case "s":
                    break;
                case "t":
                    break;
                case "u":
                    break;
                case "v":
                    break;
                case "w":
                    break;
                case "x":
                    break;
                case "y":
                    break;
                case "z":
                    break;
                default:
                    result = false;
                    break;
            }
            return result;
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            //throw new NotImplementedException();
            var tally = vals.Length;
            var result = tally % 2;
            if (result == 0)
            {
                return true;
            } else
            {
                return false;
            }
        }

        public bool IsNumberEven(int number)
        {
            //throw new NotImplementedException();
            var result = number % 2;
            if (result == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsNumberOdd(int num)
        {
            //throw new NotImplementedException();
            //throw new NotImplementedException();
            var result = num % 2;
            if (result != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            //throw new NotImplementedException();
            //var set = numbers.GetEnumerator();
            if (numbers == null || numbers.Count() < 1)
            {
                return 0;
            }
            return numbers.Max() + numbers.Min();
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            //throw new NotImplementedException();
            var Length1 = str1.Length;
            var Length2 = str2.Length;
            if (Length1 < Length2)
            {
                return Length1;
            } else
            {
                return Length2;
            }
        }

        public int Sum(int[] numbers)
        {
            //throw new NotImplementedException();
            if (numbers == null || numbers.Length == 0)
            {
                return 0;
            }
            int i = 0;
            int tally = numbers.Length;
            var result = 0;
            for (i=0; i < tally; i++)
            {
                result += numbers[i];
            }
            return result;
        }

        public int SumEvens(int[] numbers)
        {
            //throw new NotImplementedException();
            if (numbers == null || numbers.Length == 0)
            {
                return 0;
            }
            int i = 0;
            int tally = numbers.Length;
            var result = 0;
            for (i = 0; i < tally; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    result += numbers[i];
                }
            }
            return result;
        }

        public bool IsSumOdd(List<int> numbers)
        {
            //throw new NotImplementedException();
            if (numbers == null)
            {
                return false;
            }
            var sum = 0;
            var tally = numbers.Count;
            int i = 0;
            for (i = 0; i < tally; i++)
            {
                sum += numbers[i];
            }
            var result = sum % 2;
            if (result != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            //throw new NotImplementedException();
            if (number == null)
            {
                return 0;
            }
            long i = 0;
            //var converted = number.ToString();
            //int tally = int.Parse(converted);
            long tally = number;
            long result = 0;
            for (i = tally - 1; i >= 1; i -= 1)
            {
                if (i % 2 != 0)
                {
                    result += 1;
                }
            }
            return result;
        }
    }
}
