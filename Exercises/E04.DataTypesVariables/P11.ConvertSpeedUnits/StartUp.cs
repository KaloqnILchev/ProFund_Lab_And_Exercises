namespace P11.ConvertSpeedUnits
{
    using System;

    public class StartUp
    {
        public  static void Main(string[] args)
        {
            float distanceInMeter = float.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            int seconds = int.Parse(Console.ReadLine());

            float totalTimeInSeconds = (hours * 60F * 60F) + (minutes * 60F) + seconds;
            float distanceInKm = distanceInMeter / 1000F;
            float distanceInMile = distanceInMeter / 1609F;

            float metersPerSecond = distanceInMeter / totalTimeInSeconds;
            float kilometersPerHour = distanceInKm * (3600F / totalTimeInSeconds);
            float milesPerHour = distanceInMile * (3600F / totalTimeInSeconds);

            Console.WriteLine("{0}", metersPerSecond);
            Console.WriteLine("{0}", kilometersPerHour);
            Console.WriteLine("{0}", milesPerHour);

        }
    }
}