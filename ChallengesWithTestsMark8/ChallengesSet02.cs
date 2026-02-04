using System;
using System.Collections.Generic;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            string alaphabetLower = "abcdefghijklmnopqrstuvwxyz";
            string alaphabetUpper = alaphabetLower.ToUpper();
            char[] lowerCaseAlaphabet = alaphabetLower.ToCharArray();
            char[] upperCaseAlaphabet = alaphabetUpper.ToCharArray();
            for (int i = 0; i < lowerCaseAlaphabet.Length; i++)
            {
                if (lowerCaseAlaphabet[i] == c)
                {
                    return true;
                }

                if (upperCaseAlaphabet[i] == c)
                {
                    return true;
                }
            }
            return false;
            
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            throw new NotImplementedException();
        }

        public bool IsNumberEven(int number)
        {
            if (number % 2 == 0 && number % -2 == 0)
            {
                return  true;
            }
            else{return false;}
        }
        

        public bool IsNumberOdd(int num)
        {
            if (num % 1 == 0 && num % -1 == 0)
            {
                return true;
            }
            if (num ! % 2 == 0 && num % -2 == 0)
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
            if (numbers == null)
            {
                return 0;   
            }

            double? min = null; 
            double? max = null;

            foreach (var x in numbers)
            {
                if (min == null || x < min) min = x;
                if (max == null || x > max) max = x;
            }

            if (min == null || max == null)
            {
                return 0;
            }
            return min.Value + max.Value;
        }
        

        public int GetLengthOfShortestString(string str1, string str2)
        {
            throw new NotImplementedException();
        }

        public int Sum(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                return 0;
            }
            int sum = 0;
            foreach (var x in numbers)
            {
                sum += x;
            }
            return sum;
        }

        public int SumEvens(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                return 0;
            }
            int sum = 0;
            foreach (var x in numbers)
            {
                sum += (x % 2 ==  0) ? x : 0;
            } 
            return sum;

          
           
        }

        public bool IsSumOdd(List<int> numbers)
        {
            if (numbers == null || numbers.Count == 0)
            {
                return false;
            }
            int sum = 0;
            foreach (var x in numbers)
            {
                sum += x; 
            }

            if (sum % 2 != 0)
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
            throw new NotImplementedException();
        }
    }
}
