using System;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter any digits: ");
            string userInput = Console.ReadLine(); // Collecting the user input

            string reversedString = Reverse(userInput); // Passing the input to the reverse method to reverse it

            if(IsPalindrome(userInput, reversedString)) Console.WriteLine("The entered digit is a palindrome"); 


            else Console.WriteLine("The entered digit is not a palindrome");
            //Displaying the output to he user based of if the input is a palindrome or not

        }


        public static string Reverse(string digits){
            char [] digitsArray = digits.ToCharArray();
            //Converting the input to an array of character

            Array.Reverse(digitsArray); //using the array reverse method to reverse the array

            return new string(digitsArray); // joining the reversed array to form a new string and returring it 
        }

        public static bool IsPalindrome(string originalString, string reversedString){
            return originalString.Equals(reversedString);
            // returing true or false based on the result of checking if the reversed string is the same as the original user input
        }
    }
}
