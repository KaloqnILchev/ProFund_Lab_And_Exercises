using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P10.CubeProperties
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            double sideLenght = double.Parse(Console.ReadLine());
            string parameter = Console.ReadLine().ToLower();

            switch (parameter)
            {
                case "face":
                    CalculateCubeFace(sideLenght);
                    break;
                case "space":
                    CalculateCubeSpace(sideLenght);
                    break;
                case "volume":
                    CalculateCubeVolume(sideLenght);
                    break;
                case "area":
                    CalculateCubeArea(sideLenght);
                    break;
                default:
                    break;
            }
        }

        private static void CalculateCubeFace(double sideLenght)
        {
            double faceDiagonal = Math.Sqrt(2 * Math.Pow(sideLenght, 2));
            Console.WriteLine("{0:F2}", faceDiagonal);
        }

        private static void CalculateCubeSpace(double sideLenght)
        {
            double spaceDiagonal = Math.Sqrt(3 * Math.Pow(sideLenght, 2));
            Console.WriteLine("{0:F2}", spaceDiagonal);
        }

        private static void CalculateCubeVolume(double sideLenght)
        {
            double volumeOfCube = Math.Pow(sideLenght, 3);
            Console.WriteLine("{0:F2}", volumeOfCube);
        }

        private static void CalculateCubeArea(double sideLenght)
        {
            double areaOfCube = sideLenght * sideLenght;
            double totalCubeArea = 6 * areaOfCube;
            Console.WriteLine("{0:F2}", totalCubeArea);
        }
        
    }
}
