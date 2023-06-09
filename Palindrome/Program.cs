using System;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (string arg in args)
            {
                bool isPalindrome = IsPalindrome(arg);
                Console.WriteLine($"{arg} -> {isPalindrome}");
            }
        }

        static bool IsPalindrome(string input)
        {
            if (input == null)
            {
                throw new ArgumentNullException();
            }

            if (input.Length < 2)
            {
                return true;
            }

            return IsPalindromeRecursive(input);
        }

        static bool IsPalindromeRecursive(string input)
        {
            int left = 0;
            int right = input.Length - 1;

            while (left < right)
            {
                if (input[left] != input[right])
                {
                    return false;
                }

                left++;
                right--;
            }

            return true;
        }
    }
}
