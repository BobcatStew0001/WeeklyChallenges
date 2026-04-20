using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet06
    {
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
        {
            if (words is null) return false;
            return words.Any(x => !string.IsNullOrEmpty(x) && x.Equals(word, ignoreCase ? StringComparison.OrdinalIgnoreCase : StringComparison.Ordinal)); 
            
        }

        public bool IsPrimeNumber(int num)
        {
            if(num <= 1) 
                return false;
            else if (num == 2)
                return true;
            else if (num % 2 == 0)
                return false;
            for (int i = 3; i * i <= num; i += 2)
            {
                if (num % i == 0)
                    return false;
                
            }
            
            return true;
        }

        public int IndexOfLastUniqueLetter(string str)
        {
            if (string.IsNullOrEmpty(str) || str.Length == 0)
                return -1;
            var result = new Dictionary<char, int>();
            for (int i = 0; i < str.Length; i++)
            {
                if (!result.ContainsKey(str[i]))
                    result.Add(str[i], 1);
                else
                    result[str[i]]++;
            }

            for (int x = str.Length - 1; x >= 0; x--)
            {
                if(result[str[x]] == 1)
                    return x;
                
            }
            return -1;
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
            if (elements == null || elements.Count == 0 || n <= 0)
            {
                return []; 
            }
            var result = new List<double>();
            for (int i = n - 1; i < elements.Count; i+=n)
            {
                result.Add(elements[i]);
            }
            return result.ToArray();
        }
        
    }
}
