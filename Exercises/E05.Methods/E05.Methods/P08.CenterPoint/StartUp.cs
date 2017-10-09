using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P08.CenterPoint
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            CloseToCenter(x1, y1, x2, y2);
        }

        private static void CloseToCenter(double x1, double y1, double x2, double y2)
        {
            if ((Math.Abs(x1) < Math.Abs(x2)) && (Math.Abs(y1) < Math.Abs(y2)))
            {
                Console.WriteLine($"({x1}, {y1})");
            }
            else if ((Math.Abs(x1) == Math.Abs(x2)) && (Math.Abs(y1) == Math.Abs(y2)))
            {
                Console.WriteLine($"({x1}, {y1})");
            }
            else
            {
                Console.WriteLine($"({x2}, {y2})");
            }
        }
    }
}
