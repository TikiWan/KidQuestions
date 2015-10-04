using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KidTraining
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new Palindrome().IsPalindrome("ABBA"));

            Console.WriteLine(new Palindrome().MaxPalindromeForProductOfAnyTwoDigitNumber());

            Console.WriteLine(new Palindrome().MaxPalindromeForSquareOfTwoDigitNumber());
        }
    }
}
