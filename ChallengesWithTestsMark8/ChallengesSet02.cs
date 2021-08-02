using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            return char.IsLetter(c);
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            if (vals.Length % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsNumberEven(int number)
        {
            if (number % 2 == 0)
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
            if (num % 2 == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            if (numbers == null)
            {
                return 0;
            }
            else if (numbers.Count() == 0)
            {
                return 0;
            }
            else
            {
                double min = numbers.Min();
                double max = numbers.Max();
                double sum = min + max;
                return sum;
            }
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            int strLength1 = str1.Length;
            int strLength2 = str2.Length;
            if (strLength1 < strLength2)
            {
                return strLength1;
            }
            else
            {
                return strLength2;
            }
        }

        public int Sum(int[] numbers)
        {
            if (numbers == null)
            {
                return 0;
            }
            else
            {
                int total = 0;
                for (int i = 0; i < numbers.Length; i++)
                {
                    total += numbers[i];
                }
                return total;
            }
        }

        public int SumEvens(int[] numbers)
        {
            int evens = 0;
            if (numbers == null)
            {
                return 0;
            }
             for (int i = 0; i < numbers.Length; i++) 
            {
                if (numbers[i] % 2 == 0)
                {
                    evens += numbers[i];
                }
            }
            return evens;
        }

        public bool IsSumOdd(List<int> numbers)
        {
            if (numbers == null)
            {
                return false;
            }
            int total = numbers.Sum();
            if (total %  2 == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            if (number <= 0)
            {
                return 0;
            }
            else
            {
                return number / 2;
            }
        }

    }
}
