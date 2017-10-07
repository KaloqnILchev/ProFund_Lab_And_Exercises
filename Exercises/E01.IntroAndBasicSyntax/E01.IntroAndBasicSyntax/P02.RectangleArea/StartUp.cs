namespace P02.RectangleArea
{
    using System;
    public class StartUp
    {
        public static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            double area = width * height;

            Console.WriteLine("{0:F2}", area);
        }
    }
}
