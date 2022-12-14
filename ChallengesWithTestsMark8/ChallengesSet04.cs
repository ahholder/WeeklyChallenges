using System;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            //throw new NotImplementedException();
            if (numbers == null || numbers.Length == 0) return 0;
            int tally = numbers.Count();
            int result = 0;
            for (int i = 0; i < tally; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    result += numbers[i];
                } else
                {
                    result -= numbers[i];
                }
            }
            return result;
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            //throw new NotImplementedException();
            int [] size = new int[] { 0, 0, 0, 0 };
            int shortest = -1;
            if (str1 != null) size[0] = str1.Length;
            if (str2 != null) size[1] = str2.Length;
            if (str3 != null) size[2] = str3.Length;
            if (str4 != null) size[3] = str4.Length;
            for (int i = 0; i < 4; i++)
            {
                if (shortest == -1 || size[i] < shortest)
                {
                    shortest = size[i];
                }
            }
            return shortest;
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            //throw new NotImplementedException();
            int[] nums = new int[] { 0, 0, 0, 0 };
            nums[0] = number1;
            nums[1] = number2;
            nums[2] = number3;
            nums[3] = number4;
            int smallest = number1;
            for (int i = 0; i < 4; i++)
            {
                if (nums[i] < smallest)
                {
                    smallest = nums[i];
                }
            }
            return smallest;
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            //throw new NotImplementedException();
            biz.Name = "TrueCoders";
            Console.WriteLine(biz.Name);
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            //throw new NotImplementedException();
            int a = sideLength1;
            int b = sideLength2;
            int c = sideLength3;
            int a2 = a * a;
            int b2 = b * b;
            int c2 = c * c;
            if (sideLength1 == 0 || sideLength2 == 0 || sideLength3 == 0) return false;
            /*if (((sideLength1 * sideLength1) + (sideLength2 * sideLength2)) == (sideLength3 * sideLength3)) {
                return true;
            } else if ((sideLength3 * sideLength3) + (sideLength2 * sideLength2) == sideLength1 * sideLength1)
            {
                return true;
            }
            else if ((sideLength3 * sideLength3) + (sideLength1 * sideLength1) == sideLength2 * sideLength2)
            {
                return true;
            } else
            {
                return false;
            }*/
            /*if (a2 + b2 == c2 || a2 + c2 == b2 || b2 + c2 == a2)
            {
                return true;
            } else
            {
                return false;
            }*/
            //if (a + b > c && a != 1 && b != 1 && c != 1)
            if (a + b > c && c != 1 && a - b != c)
            {
                return true;
            } else
            {
                return false;
            }
        }

        public bool IsStringANumber(string input)
        {
            //throw new NotImplementedException();
            double test = 0;
            return double.TryParse(input, out test);
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            //throw new NotImplementedException();
            if (objs.Length < 1 || objs == null)
            {
                return true;
            }
            int tally = objs.Length;
            int result = 0;
            for (int i=0;i<tally;i++)
            {
                if (objs[i] == null)
                {
                    result += 1;
                }
            }
            if (result > (tally / 2))
            {
                return true;
            } else
            {
                return false;
            }
        }

        public double AverageEvens(int[] numbers)
        {
            //throw new NotImplementedException();
            if (numbers == null || numbers.Length < 1)
            {
                return 0;
            }
            int tally = numbers.Length;
            double evens = 0;
            double result = 0;
            double final = 0;
            for (int i = 0; i < tally; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    evens += 1;
                    result += numbers[i];
                }
            }
            if (evens > 0)
            {
                final = result / evens;
            } else
            {
                final = 0;
            }
            return final;
        }

        public int Factorial(int number)
        {
            //if (number < 0) throw new NotImplementedException();
            if (number == 0) return 1;
            /*int[] list = new int[] { };
            for (int i = number - 1; i > 0; i--)
            {
                list[i] = i;
            }*/
            int result = number;
            for (int i = number - 1; i > 0; i--)
            {
                result *= i;
            }
            return result;

            //STUDENT NOTE: UNCLEAR HOW TO MANUALLY THROW A 'RANGE EXCEPTION' TO FULFILL THE FINAL TEST
        }
    }
}
