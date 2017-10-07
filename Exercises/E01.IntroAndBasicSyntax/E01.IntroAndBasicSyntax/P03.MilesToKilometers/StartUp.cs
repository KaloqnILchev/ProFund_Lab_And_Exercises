namespace P03.MilesToKilometers
{
    using System;
    public class StartUp
    {
        public static void Main(string[] args)
        {
            double miles = double.Parse(Console.ReadLine());
            double oneMileToKilometer = 1.60934;

            double kilometers = miles * oneMileToKilometer;

            Console.WriteLine("{0:F2}", kilometers);
  
        }
    }
}
