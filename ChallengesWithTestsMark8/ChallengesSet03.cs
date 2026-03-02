using System;
using System.Collections.Generic;
using System.Linq; //Added this because it was recommended by the AI as an easier way. 

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
            
            // Why does the if null statement have to come in the beginning? I had my foreach first and could not get 
            // the code to pass correctly. Shouldn't it run through the foreach and if the test doesn't meet the scope 
            //filter to the if statement?
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)//Used the Linq here. 
        {
            return password.Any(char.IsUpper) && password.Any(char.IsLower) && password.Any(char.IsNumber);
        }
        //In a situation like this should I put it on three seperate lines for better readability or keep it on one line
        

        public char GetFirstLetterOfString(string val)
        {
            return val[0];
        }

        public char GetLastLetterOfString(string val)
        {
            return val[val.Length - 1];
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
         return nums[nums.Length - 1] -  nums[0];
        }
        //Why can you say nums[nums.Length-1]-nums[0] but not nums[0]-nums[nums.Length-1]? The 2nd way kept 
        //throwing an error saying the (-) couldn't be applied. 

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
            for(int i =0;i<words.Length;i++)
            {
                words[i] = words[i].ToUpper();
            }//why can you not just apply the ToUpper() directly to the string[] by saying string[string.ToUpper()]?
        }
        
    }
}
