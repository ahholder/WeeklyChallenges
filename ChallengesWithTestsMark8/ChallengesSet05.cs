using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks.Dataflow;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet05
    {
        public int GetNextNumberDivisibleByN(int startNumber, int n)
        {
            //throw new NotImplementedException();
            int i = startNumber + 1;
            while (i % n != 0)
            {
                i++;
            }
            return i;
        }

        public void ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(Business[] businesses)
        {
            //throw new NotImplementedException();
            foreach (Business job in businesses)
            {
                if (job.TotalRevenue == 0)
                {
                    job.Name = "CLOSED";
                }
            }
        }

        public bool IsAscendingOrder(int[] numbers)
        {
            //throw new NotImplementedException();
            if (numbers == null || numbers.Length < 1) return false;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (i > 0 && numbers[i] < numbers[i - 1]) return false;
            }
            return true;
        }

        public int SumElementsThatFollowAnEven(int[] numbers)
        {
            //throw new NotImplementedException();
            if (numbers == null || numbers.Length < 1) return 0;
            var tallying = false;
            var sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (tallying == true) sum += numbers[i];
                if (numbers[i] % 2 == 0)
                {
                    tallying = true;
                } else
                {
                    tallying = false;
                }
            }
            return sum;
        }

        public string TurnWordsIntoSentence(string[] words)
        {
            //throw new NotImplementedException();
            //int tally = 0;
            if (words == null || words.Length < 1) return "";
            string coherent = "";
            int test = 0;
            string tester = "";
            int testercount = 0;
            foreach (var word in words)
            {
                tester = "";
                for (int i = 0; i < word.Length; i++)
                {
                    if (word[i].ToString() != " ") tester += word[i].ToString();
                }
                if (word != tester) words[testercount] = tester;
                testercount += 1;
            }
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i] != "" && words[i] != " " && words[i] != null) {
                    if (i > 0 && words[i] != null) coherent += " ";
                    coherent += words[i];
                    if (i == words.Length - 1 && words.Length > 0 && coherent != "" && coherent != " ") coherent += ".";
                }
                //test = i;
            }
            //coherent += $" {test}";
            return coherent;
        }

        public double[] GetEveryFourthElement(List<double> elements)
        {
            //throw new NotImplementedException();
            double[] emptyList = new double[] { };
            if (elements == null || elements.Count < 4) return emptyList;
            var list = new List<double>();
            double[] checklist = elements.ToArray();
            //int tally = 0;
            int counter = 0;
            for (int i = 0; i < checklist.Length;i++)
            {
                counter += 1;
                if (counter % 4 == 0)
                {
                    list.Add(checklist[i]);
                }
            }
            double[] finalList = list.ToArray();
            return finalList;
        }

        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
        {
            //throw new NotImplementedException();
            bool result = false;
            int i = 0;
            int i2 = 0;
            for (i=0;i<nums.Length;i++)
            {
                for (i2=0;i2<nums.Length;i2++)
                {
                    if (i != i2 && nums[i] + nums[i2] == targetNumber)
                    {
                        result = true;
                    }
                }
            }
            return result;
        }
    }
}
