using System;
using System.Collections.Generic;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            if (vals ==  null)
            {
                return false;
            }

            for (int i = 0; i < vals.Length; i++)
            {
                if (vals[i] == false)
                    return true;
            }
            return false;
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            if (numbers == null) return false;

            int oddCount = 0;
            foreach (var num in numbers)
            {
                
                if ((num & 1) != 0) oddCount++;
            }
            return (oddCount & 1) != 0;
            
            
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            throw new NotImplementedException();
        }

        public char GetFirstLetterOfString(string val)
        {
            throw new NotImplementedException();
        }

        public char GetLastLetterOfString(string val)
        {
            throw new NotImplementedException();
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            if (divisor == 0)
            {
                return 0; 
            }

            return dividend / divisor;
        }

        public int LastMinusFirst(int[] nums)
        {
            throw new NotImplementedException();
        }

        public int[] GetOddsBelow100()
        {
            int[] odds = new int[50];
            int index = 0;
            for (int i = 1; i < 100; i += 2)
            {
                odds[index] = i;
                index++;
            }
           return odds;
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            throw new NotImplementedException();
        }
    }
}
