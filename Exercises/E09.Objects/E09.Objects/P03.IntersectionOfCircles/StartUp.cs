namespace P03.IntersectionOfCircles
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public class Circle
        {
            public double X { get; set; }
            public double Y { get; set; }
            public double Radius { get; set; }
        }

        public static void Main(string[] args)
        {
            double[] firstInput = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            double[] secondInput = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

            //create the first center point and set the first circle properties

            Circle firstCircle = new Circle();
            firstCircle.X = firstInput[0];
            firstCircle.Y = firstInput[1];
            firstCircle.Radius = firstInput[2];

            //create the secont center point and set the first circle properties

            Circle secondCircle = new Circle();
            secondCircle.X = secondInput[0];
            secondCircle.Y = secondInput[1];
            secondCircle.Radius = secondInput[2];

            bool circlesIntersect = Intersect(firstCircle, secondCircle);
            if (circlesIntersect)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }


        }

        static public bool Intersect(Circle firstCircle, Circle secondCircle)
        {
            //find the distance between the points
            double deltaX = Math.Abs(firstCircle.X - secondCircle.X);
            double deltaY = Math.Abs(firstCircle.Y - secondCircle.Y);
            double distance = Math.Sqrt(Math.Pow(deltaX, 2) + Math.Pow(deltaY, 2));
            double sumRadiuses = firstCircle.Radius + secondCircle.Radius;

            //if the distance between the points is greater than the sum of the radiuses AND
            //if the radius of the smaller circle + the distance between the points is NOT
            //less than the radius of the larger circle, the circles intersect
            /* !(Math.Min(firstCircle.Radius, secondCircle.Radius) +
                distance < Math.Max(firstCircle.Radius, secondCircle.Radius)) */

            if (sumRadiuses >= distance)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}