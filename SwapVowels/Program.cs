using System;

namespace SwapVowels
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter any word or sentence to encode: ");
            string userInput = Console.ReadLine();
            char [] userInputArray = userInput.ToCharArray();

            for (int i = 0; i < userInputArray.Length; i++)
            {
                userInputArray[i] = SwapVowel( userInputArray[i]);
            }

            Console.WriteLine($"The Encoded sentence is: {new string(userInputArray)}");
        }

        public static char SwapVowel(char character)
        {
            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };

            for (int i = 0; i < vowels.Length; i++)
            {
                if (vowels[i] == character)
                {
                    if (i == vowels.Length - 1) return vowels[0];
                    return vowels[i + 1];
                }
            }

            return character;
        }
    }
}
