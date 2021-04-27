using System;

namespace SquareRoot
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number you want to square root: ");
            double userNumber = Convert.ToDouble(Console.ReadLine());
            //Getting user input and converting it to double


            if (userNumber < 0)
            {
                Console.WriteLine("Number must be >= 0");
                return;
                //checking if its a positive number, displaying appropriate methos if its not and breaking out of the method
            }
            if (userNumber == 0 || userNumber == 1)
            {
                Console.WriteLine($"Square root of {userNumber} is {userNumber}");
                return;
                //The square root of 1 and 0 is themself
            }
            else
            {
                double squareRoot = Sqrt(userNumber); //passing the user input to the Sqrt method to compute the square root of the number
                
                Console.WriteLine($"The approximate square root of {userNumber} is {squareRoot}");
                //Displaying th square root of the number to the user
            }


        }

        public static double Sqrt(double n)
        {
            double lastGuess; // a variable for holdong previous guess
            
            double nextGuess = 1; //initializing the next guess to be 1 as a startoff 
            do
            {
                lastGuess = nextGuess; // passing our previous guess to the lastguess variable since its not the one (1 cant be the coreect value too. we handled that already)
                
                nextGuess = (lastGuess + (n / lastGuess)) / 2; // computing for the next guess
            } 
            while (lastGuess - nextGuess >= 0.0001 || nextGuess - lastGuess >= 0.0001);
            //checking if the diffrence between the guesses is between of exactly our 0.0001 precision
            
            return nextGuess; // returning the nearest square root found
        }
    }
}
