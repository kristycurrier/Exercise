using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise44
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter coordinates: ");
            string coordinates1 = Console.ReadLine();
            string[] values1 = coordinates1.Split(' ');
            int xCoordinate1 = int.Parse(values1[0]);
            int yCoordinate1 = int.Parse(values1[1]);

            Console.WriteLine("Enter coordinates: ");
            string coordinates2 = Console.ReadLine();
            string[] values2 = coordinates2.Split(' ');
            int xCoordinate2 = int.Parse(values2[0]);
            int yCoordinate2 = int.Parse(values2[1]);


            var firstPoint = new Point(xCoordinate1, yCoordinate1);
            var secondPoint = new Point(xCoordinate2, yCoordinate2);

            var midPoint = Point.CalculateMidpoint(firstPoint, secondPoint);

            Console.WriteLine($"The midpoint of the two points is {midPoint.XValue}, {midPoint.YValue}.");

            //var distance = Point.CalculateDistance(firstPoint);

            //Console.WriteLine($"You have created a point object ({firstPoint.XValue}, {firstPoint.YValue}). It has a distance of {distance}.");
            Console.ReadKey();
        }
    }

    class Point
    {
        public double XValue { get; set; }
        public double YValue { get; set; }

        public Point(int xValue, int yValue)
        {
            XValue = Convert.ToDouble(xValue);
            YValue = Convert.ToDouble(yValue);
        }

        public Point(double xValue, double yValue)
        {
            XValue = xValue;
            YValue = yValue;
        }

        public static int CalculateDistance(Point point)
        {
            double distance = Math.Sqrt((point.XValue * point.XValue) + (point.YValue * point.YValue));
            int distanceRounded = Convert.ToInt32(distance);
            return distanceRounded;
        }

        public static Point CalculateMidpoint(Point point1, Point point2)
        {
            double midPointX = (point1.XValue + point2.XValue) / 2;
            double midPointY = (point1.YValue + point2.YValue) / 2;

            var midPoint = new Point(midPointX, midPointY);
            return midPoint;
        }
    }

}

