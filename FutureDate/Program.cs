using System;

namespace FutureDate
{
    class Program
    {
        static void Main(string[] args)
        {
            string [] days = {"Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday"};

            Console.WriteLine("Pick today's day of the week:");

            for (int i = 0; i < days.Length; i++)
            {
                Console.WriteLine($"{i}. {days[i]}");
            }

            int currentDay = Convert.ToInt32(Console.ReadLine());

            if(currentDay < 0 || currentDay > days.Length -1){
                Console.WriteLine("Pick a valid day");
            }

            else{
                
                Console.WriteLine($"You picked {days[currentDay]}");
                
                Console.Write("Enter the number of days after today to determine: ");
                
                int numberOfDaysInFuture = Convert.ToInt32(Console.ReadLine());

                string dayInFuture = days[(numberOfDaysInFuture+currentDay) % 7];

                Console.WriteLine($"\n{numberOfDaysInFuture} days into the future is {dayInFuture}");
                
            }
        }
    }
}
