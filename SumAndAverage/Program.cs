using System;

namespace SumAndAverage
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] array = { new int[] { 2, 4, 6, 3, 4, 7 }, new int[] { 5, 2, 9, 4, 6, 0 } };
            //creating a new 2D array

            int numberOfValues = 0;
            int totalSum = 0;
            //intializing some variables 

            for (int i = 0; i < array[0].Length; i++) //lopping through the index of the first array
            {
                int sumOfCorrespondingElement = array[0][i] + array[1][i]; //sums the corresponding element in both array

                if (sumOfCorrespondingElement % 2 != 0) // checks if the sum is an odd number
                {
                    totalSum += sumOfCorrespondingElement; //adds the sum of the corresponding elements to the total sum if it is odd
                    numberOfValues++; //increases number of  values by 1
                }
            }

            Console.WriteLine($"The sum of the values added to odd number is : {totalSum}");
            // displaying the sum to the user
            Console.WriteLine($"The average of the values added to odd number is : {totalSum / numberOfValues}");
            //dividing the sum by the number of values and displaying the quotient to the user as the average


        }
    }
}
