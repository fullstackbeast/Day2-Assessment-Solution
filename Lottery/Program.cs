using System;

namespace Lottery
{
    class Program
    {
        static void Main(string[] args)
        {

            Random random = new Random();
            int randomDigit = random.Next(100, 1000);


            Console.Write("Enter three number: ");
            string userInput = Console.ReadLine();

            if (userInput.Length != 3)
            {
                Console.WriteLine("Enter three digits");
            }
            else
            {
                int userDigit = 0;

                bool isNumbers = int.TryParse(userInput, out userDigit);

                if (!isNumbers)
                {
                    Console.WriteLine("Enter Numbers only");
                }
                else
                {
                    if (userDigit == randomDigit)
                    {
                        Console.WriteLine("You guessed the digits correctly and you have won $10,000!!!");
                    }
                    else
                    {

                        string randomDigitString = randomDigit.ToString();
                        string userDigitString = userDigit.ToString();

                        int correctDigit = 0;

                        for (var i = 0; i < 3; i++)
                        {
                            if (randomDigitString.IndexOf(userDigitString[i]) != -1) correctDigit++;
                        }

                        if (correctDigit > 0) Console.WriteLine($"You got {correctDigit} numbers correctly. You have won ${correctDigit * 1000}!!!");
                        else Console.WriteLine("You guessed wrong!!!");

                    }
                }
            }


        }
    }
}
