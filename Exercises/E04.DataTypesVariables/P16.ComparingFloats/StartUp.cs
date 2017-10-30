namespace P16.ComparingFloats
{
    using System;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            double firstNum = double.Parse(Console.ReadLine());
            double secondNum = double.Parse(Console.ReadLine());

            double difference = 0.000001;

            if ( Math.Abs (firstNum - secondNum) <= difference)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }
    }
}
