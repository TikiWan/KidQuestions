using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KidTraining
{
    public class Palindrome
    {
        public int MaxPalindromeForProductOfAnyTwoDigitNumber()
        {
            int maxPalindrome = -1;

            for (int i = 10; i <= 99; i++)
            {
                for (int j = 10; j <= 99; j++)
                {
                    int testValue = i * j;

                    if (IsPalindrome(testValue.ToString()))
                    {
                        // Update the max palindrome value when we find a new palindrom which is bigger than the current one
                        maxPalindrome = testValue;

                    }
                }
            }

            if (maxPalindrome == -1)
                throw new Exception("There is no palindrom detected");

    

            return maxPalindrome;
        }

        /// <summary>
        /// Find out the largest palindrome which is the product of a 2 digit number
        /// </summary>
        public int MaxPalindromeForSquareOfTwoDigitNumber()
        {
            int maxPalindrome = -1;

            for (int i = 10; i <= 99; i++)
            {
                int testValue = i * i;

                if (IsPalindrome(testValue.ToString()))
                {
                    // Update the max palindrome value when we find a new palindrom which is bigger than the current one
                    maxPalindrome = testValue;
                }
            }

            if (maxPalindrome == -1)
                throw new Exception("There is no palindrom detected");

            return maxPalindrome;
        }


        public bool IsPalindrome(string value)
        {
            if (value == null)
                throw new ArgumentNullException("Test value can't be null");

            int lengthOfValue = value.Length;

            // If the first and last number are different, then it is not a palindrome
            // Else continue to the second first and last number until it reach the center
            for (int i = 0; i < value.Length / 2; i++)
            {
                if (value[i] != value[lengthOfValue - (i + 1)])
                    return false;
            }
            return true;
        }
    }

}
