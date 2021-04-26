using System;

namespace RectangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the length of the rectangle: ");
            double length = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the breadth of the rectangle: ");
            double breadth = Convert.ToDouble(Console.ReadLine());

            Area area = new Area(length, breadth);
            double rectangleArea = area.ReturnArea();

            Console.WriteLine($"The area of the rectangle is: {rectangleArea}");

        }
    }
}
