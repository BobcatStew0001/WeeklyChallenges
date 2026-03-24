using System;
using System.Linq;
using System.Collections.Generic;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            if (numbers == null) return 0;
            return numbers.Sum(x => x % 2 == 0 ? x : -x);
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            List<string> strings = new List<string> { str1, str2, str3, str4 };
            int results = strings.Min(s => s.Length);
            return results;

        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            List<int> numbers = new List<int>(){ number1, number2, number3, number4 };
            int results = numbers.Min(x => x);
            return results;
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            if (biz != null)
            {
                biz.Name = "TrueCoders";
            }
        }
        

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            return (sideLength1 + sideLength2 > sideLength3) &&
                   (sideLength1 + sideLength3 > sideLength2) &&
                   (sideLength2 + sideLength3 > sideLength1);
        }

        public bool IsStringANumber(string input)
        {
            if(input == null) return false;
            return double.TryParse(input, out _);
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
           var obj = objs.Count(x => x == null);
           return obj > objs.Length / 2.0;
        }

        public double AverageEvens(int[] numbers)
        {
            {
                if (numbers == null || numbers.Length == 0) return 0;
    
                var evens = numbers.Where(x => x % 2 == 0);
    
                if (evens.Count() == 0) return 0;
    
                return evens.Average();
            }
        }


        public int Factorial(int number)
        {
            if (number < 0) throw new ArgumentOutOfRangeException();

            int result = 1;

            for (int i = number; i > 0; i--)
            {
                result *= i;
            }

            return result; 
        }
    }

    
}
