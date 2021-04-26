using System;

namespace OddIndex
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numberArray = { 2, 4, 7, 1, 4, 7, 8, 6, 2, 5, 2, 9, 3 };

            int sum = 0;

            // Method 1
            for (int i = 0; i < numberArray.Length; i++)
            {
                if (i % 2 != 0)
                {
                    sum += numberArray[i];
                }
            }

            // method 2
            int index = 1;
            while (index < numberArray.Length)
            {
                sum += numberArray[index];
                index+=2;
            }

            Console.WriteLine($"The sum of the element of the array at odd index is:  {sum}");
        }
    }
}
