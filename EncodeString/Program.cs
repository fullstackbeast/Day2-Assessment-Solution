using System;

namespace EncodeString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input any word or sentence of even length: ");

            string inputWord = Console.ReadLine();

            if (inputWord.Length == 0 || inputWord.Length % 2 != 0)
            {
                Console.WriteLine("The word is not of even length");
            }
            else
            {
                string firstPart = inputWord.Substring(0, inputWord.Length / 2);
                string secondPart = inputWord.Substring(inputWord.Length / 2);

                Console.WriteLine(Encode(firstPart, secondPart));
            }
        }


        public static string Encode(string firstPart, string secondPart)
        {
            char[] encondedFirstPart = firstPart.ToCharArray();
            char[] encodedSecondPart = secondPart.ToCharArray();

            for (int i = 1; i < firstPart.Length; i += 2)
            { 
                encodedSecondPart[i - 1] = firstPart[i];
                encondedFirstPart[i] = secondPart[i - 1];
            }

            return $"{new string(encondedFirstPart)}{new string(encodedSecondPart)}";
        }
    }
}
