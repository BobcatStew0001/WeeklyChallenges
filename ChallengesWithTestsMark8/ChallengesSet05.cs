using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet05
    {
        public int GetNextNumberDivisibleByN(int startNumber, int n)
        {
            for (int i = startNumber + 1; i < startNumber + (n + 1); i++)
            {
                if (i % n == 0)
                {
                    return i;
                }
            }

            return -1;
        }

        public void ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(Business[] businesses)
        {
            foreach (Business business in businesses)
            {
                if (business.TotalRevenue == 0)
                {
                    business.Name = "CLOSED";
                }
            }
        }

        public bool IsAscendingOrder(int[] nums)
        {
            if (nums is null || nums.Length == 0)
            {
                return false;
            }

            for (int i = 0; i < nums.Length - 1; i++)
            {

                if (nums[i] > nums[i + 1])
                {
                    return false;
                }
            }

            return true;
        }

        public int SumElementsThatFollowAnEven(int[] numbers)
        {
            if (numbers is null || numbers.Length == 0)
            {
                return 0;
            }

            var result = 0;

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    result += numbers[i + 1];
                }
            }

            return result;
        }

        public string TurnWordsIntoSentence(string[] words)
        {
            var result = "";
            if (words is null || words.Length == 0)
            {
                return "";
            }
            for (int i = 0; i < words.Length; i++)
            {
                if (string.IsNullOrWhiteSpace(words[i]))
                {
                    continue;
                }

                if (result == string.Empty)
                    result = words[i].Trim();
                else
                    result += " " + words[i].Trim(); 
            }
            if (result == "")
            {
                return result; 
            }
            else
            {
                return result + ".";
            }

        }

        public double[] GetEveryFourthElement(List<double> elements)
        {
            if (elements == null || elements.Count == 0)
            {
                return []; 
            }
            var result = new List<double>();
            for (int i = 3; i < elements.Count; i += 4)
            {
                result.Add(elements[i]);
            }
            return result.ToArray();
        }

        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
        {
            if(nums == null || nums.Length == 0)
            {
                return false;
            }
            for (int i = 0; i < nums.Length; i++)
            {
                for (int x = i + 1; x < nums.Length; x++)
                {
                    if (targetNumber.Equals(nums[i] + nums[x]))
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        
    }
}
