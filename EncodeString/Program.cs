using System;

namespace EncodeString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input any word or sentence of even length: ");

            string inputWord = Console.ReadLine(); // Collect User's Input

            if (inputWord.Length == 0 || inputWord.Length % 2 != 0) //checking to make sure the user input is not empty and of even length
            {
                Console.WriteLine("The word is not of even length");
            }
            else
            {
                string firstPart = inputWord.Substring(0, inputWord.Length / 2); // getting the first half of the string
                string secondPart = inputWord.Substring(inputWord.Length / 2); // getting the second half of the string

                string encoded = Encode(firstPart, secondPart); //passing both half of the string to the Encode method to get it encoded

                Console.WriteLine(encoded); //displaying the encoded string to the user
            }
        }


        public static string Encode(string firstPart, string secondPart)
        {
            char[] encondedFirstPart = firstPart.ToCharArray();
            char[] encodedSecondPart = secondPart.ToCharArray();

            //converting the string to an array of character. Replacing the characters in the string directly will cause a chain reaction getting the character replaced everywhere in the string

            for (int i = 1; i < firstPart.Length; i += 2) //looping through the odd index only
            { 
                encodedSecondPart[i - 1] = firstPart[i]; // replacing the even part of the second half of the string with the odd part of the first half
                encondedFirstPart[i] = secondPart[i - 1]; // replacing the odd part of the first half of the string with the even part of the second half
            }

            return $"{new string(encondedFirstPart)}{new string(encodedSecondPart)}"; //return a concatenation of the encoded halves
        }
    }
}
