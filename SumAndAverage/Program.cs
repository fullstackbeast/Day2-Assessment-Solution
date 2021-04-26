using System;

namespace SumAndAverage
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] array = { new int[] { 2, 4, 6, 3, 4, 7 }, new int[] { 5, 2, 9, 4, 6, 0 } };

            int numberOfValues = 0;
            int totalSum = 0;

            for (int i = 0; i < array[0].Length; i++)
            {
                int sumOfCorrespondingElement = array[0][i] + array[1][i];

                if (sumOfCorrespondingElement % 2 != 0)
                {
                    totalSum += sumOfCorrespondingElement;
                    numberOfValues++;
                }
            }

            Console.WriteLine($"The sum of the values added to odd number is : {totalSum}");
            Console.WriteLine($"The average of the values added to odd number is : {totalSum / numberOfValues}");


        }
    }
}
