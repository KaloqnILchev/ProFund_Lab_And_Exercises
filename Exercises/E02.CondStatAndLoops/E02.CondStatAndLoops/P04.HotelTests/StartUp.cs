namespace P04.HotelTests
{
    using System;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nightCount = int.Parse(Console.ReadLine());

            double studioPrice = 0.0;
            double doublePrice = 0.0;
            double suitePrice = 0.0;

            if (month == "May" || month == "October")
            {
                studioPrice = 50;
                doublePrice = 65;
                suitePrice = 75;

                if (nightCount > 7)
                {
                    studioPrice = studioPrice * 95 / 100.0;
                }
            }
            else if (month == "June" || month == "September")
            {
                studioPrice = 60;
                doublePrice = 72;
                suitePrice = 82;

                if (nightCount > 14)
                {
                    doublePrice = doublePrice * 90 / 100.0;
                }
            }
            else if (month == "July" || month == "August" || month == "December")
            {
                studioPrice = 68;
                doublePrice = 77;
                suitePrice = 89;

                if (nightCount > 14)
                {
                    suitePrice = suitePrice * 85 / 100.0;
                }
            }

            double totalStudioPrice = studioPrice * nightCount;
            double totalDoublePrice = doublePrice * nightCount;
            double totaleSuitePrice = suitePrice * nightCount;

            if (month == "September" || month == "October" && nightCount > 7)
            {
                totalStudioPrice -= studioPrice;
            }
            Console.WriteLine($"Studio: {totalStudioPrice:F2} lv.");
            Console.WriteLine($"Double: {totalDoublePrice:F2} lv.");
            Console.WriteLine($"Suite: {totaleSuitePrice:F2} lv.");
        }
    }
}
