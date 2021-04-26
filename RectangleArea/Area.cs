namespace RectangleArea
{
    public class Area
    {

        private double Length;
        private double Breadth;

        public Area(double length, double breadth)
        {
            Length = length;
            Breadth = breadth;
        }

        public double ReturnArea()
        {
            return Length * Breadth;
        }
    }
}