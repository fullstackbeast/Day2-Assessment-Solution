using System;

namespace SquareRoot
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number you want to square root: ");

            double userNumber = Convert.ToDouble(Console.ReadLine());

            if (userNumber < 0)
            {
                Console.WriteLine("Number must be >= 0");
                return;
            }
            if (userNumber == 0 || userNumber == 1)
            {
                Console.WriteLine($"Square root of {userNumber} is {userNumber}");
                return;
            }
            else
            {
                double squareRoot = Sqrt(userNumber);
                Console.WriteLine($"The approximate square root of {userNumber} is {squareRoot}");
            }


        }

        public static double Sqrt(double n)
        {
            double lastGuess;
            
            double nextGuess = 1;
            do
            {
                lastGuess = nextGuess;
                nextGuess = (lastGuess + (n / lastGuess)) / 2;
            } while (lastGuess - nextGuess >= 0.0001 || nextGuess - lastGuess >= 0.0001);
            
            return nextGuess;
        }
    }
}
