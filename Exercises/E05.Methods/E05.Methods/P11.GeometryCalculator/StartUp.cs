using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P11.GeometryCalculator
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string typeOfFigure = Console.ReadLine().ToLower();

            switch (typeOfFigure)
            {
                case "triangle":
                    CalculateAreaTriangle();
                    break;
                case "square":
                    CalculateAreaSquare();
                    break;
                case "rectangle":
                    CalculateAreaRectangle();
                    break;
                case "circle":
                    CalculateAreaCircle();
                    break;

                default:
                    break;
            }
        }
        private static void CalculateAreaTriangle()
        {
            double side = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            double area = 1.0 / 2 * side * height;
            Console.WriteLine("{0:F2}", area);
        }

        private static void CalculateAreaSquare()
        {
            double side = double.Parse(Console.ReadLine());

            double area = side * side;
            Console.WriteLine("{0:F2}", area);

        }
        private static void CalculateAreaRectangle()
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            double area = width * height;
            Console.WriteLine("{0:F2}", area);
        }
        private static void CalculateAreaCircle()
        {
            double radios = double.Parse(Console.ReadLine());

            double area = Math.PI * radios * radios;
            Console.WriteLine("{0:F2}", area);
        }
    }
}

