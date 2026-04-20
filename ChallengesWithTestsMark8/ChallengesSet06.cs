using System;
using System.Collections.Generic;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet06
    {
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
        {
            throw new NotImplementedException();
        }

        public bool IsPrimeNumber(int num)
        {
            throw new NotImplementedException();
        }

        public int IndexOfLastUniqueLetter(string str)
        {
            throw new NotImplementedException();
        }

        public int MaxConsecutiveCount(int[] numbers)
        {
            if(numbers is null || numbers.Length == 0)
                return -1;
            var maxStreak = 0;
            var currentStreak = 1; 
            for (int i = 0; i < numbers.Length -1; i++)
            {
                if (numbers[i] != numbers[i + 1])
                {
                    currentStreak = 1;
                }
                else 
                {
                    currentStreak ++;
                }
                maxStreak = Math.Max(maxStreak, currentStreak);
                
            }
            return maxStreak;
        }

        public double[] GetEveryNthElement(List<double> elements, int n)
        {
            throw new NotImplementedException();
        }
    }
}
