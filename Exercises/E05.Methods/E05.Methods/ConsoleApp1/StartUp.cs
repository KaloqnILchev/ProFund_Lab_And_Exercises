using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P09.LongerLine
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double x1Line01 = double.Parse(Console.ReadLine());
            double y1Line01 = double.Parse(Console.ReadLine());
            double x2Line01 = double.Parse(Console.ReadLine());
            double y2Line01 = double.Parse(Console.ReadLine());
            double x1Line02 = double.Parse(Console.ReadLine());
            double y1Line02 = double.Parse(Console.ReadLine());
            double x2Line02 = double.Parse(Console.ReadLine());
            double y2Line02 = double.Parse(Console.ReadLine());

            CloseToCenter(x1Line01, y1Line01, x2Line01, y2Line01, x1Line02, y1Line02, x2Line02, y2Line02);
        }

        private static void CloseToCenter(double x1First, double y1First, double x2First, double y2First, double x1Second, double y1Second, double x2Second, double y2Second)
        {
            if ((Math.Abs(x1First + x2First) < Math.Abs(x1Second + x2Second)) || (Math.Abs(y1First + y2First) < Math.Abs(y1Second + y2Second)))
            {
                if ((Math.Abs(x1Second) < Math.Abs(x2Second)) && (Math.Abs(y1Second) < Math.Abs(y2Second)))
                {
                    Console.WriteLine($"({x1Second}, {y1Second })({x2Second}, {y2Second})");
                }
                else
                {
                    Console.WriteLine($"({x2Second}, {y2Second})({x1Second}, {y1Second})");
                }

            }
            else if ((Math.Abs(x1First - x2First) == Math.Abs(x1Second - x2Second)) || (Math.Abs(y1First - y2First) == Math.Abs(y1Second - y2Second)))
            {
                if ((Math.Abs(x1First) < Math.Abs(x2First)) && (Math.Abs(y1First) < Math.Abs(y2First)))
                {
                    Console.WriteLine($"({x1First}, {y1First })({x2First}, {y2First})");
                }
                else
                {
                    Console.WriteLine($"({x2First}, {y2First})({x1First}, {y1First})");
                }
            }
            else
            {
                if ((Math.Abs(x1First) < Math.Abs(x2First)) && (Math.Abs(y1First) < Math.Abs(y2First)))
                {
                    Console.WriteLine($"({x1First}, {y1First })({x2First}, {y2First})");
                }
                else
                {
                    Console.WriteLine($"({x2First}, {y2First})({x1First}, {y1First})");
                }
            }
        }
    }
}
