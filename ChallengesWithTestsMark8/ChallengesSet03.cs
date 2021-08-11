using System;
using System.Collections.Generic;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            foreach (var val in vals)
            {
                if (!val)
                {
                    return true;
                }
            }

            return false;
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            int total = 0;
            if (numbers == null)
            {
                return false;
            }
            foreach (int number in numbers)
            {
                total += number;
            }

            if (total % 2 == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            bool isUpper = false;
            bool isLower = false;
            bool isNumber = false;

            foreach (var letter in password)
            {
                if (char.IsUpper(letter))
                {
                    isUpper = true;
                }

                if (char.IsLower(letter))
                {
                    isLower = true;
                }

                if (char.IsNumber(letter))
                {
                    isNumber = true;
                }
            }

            return isUpper && isLower && isNumber;
        }

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
            else
            {
                return dividend / divisor;
            }
        }

        public int LastMinusFirst(int[] nums)
        {
            return nums[nums.Length - 1] - nums[0];
        }

        public int[] GetOddsBelow100()
        {
            var goodNumsList = new List<int>();
            for (int i = 0; i < 100; i++)
            {
                if (i % 2 != 0)
                {
                    goodNumsList.Add(i);
                }
            }
            return goodNumsList.ToArray();
        }

       public void ChangeAllElementsToUppercase(string[] words)
       {
       for (int i = 0; i < words.Length; i++)
       {
            words[i] = words[i].ToUpper();
       }
       
       }
    }
}
