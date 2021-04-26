using System;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter any digits: ");
            string userInput = Console.ReadLine();

            string reversedString = Reverse(userInput);

            if(IsPalindrome(userInput, reversedString)) Console.WriteLine("The entered digit is a palindrome");
            else Console.WriteLine("The entered digit is not a palindrome");

        }


        public static string Reverse(string digits){
            char [] digitsArray = digits.ToCharArray();

            Array.Reverse(digitsArray);

            return new string(digitsArray);
        }

        public static bool IsPalindrome(string originalString, string reversedString){
            return originalString.Equals(reversedString);
        }
    }
}
