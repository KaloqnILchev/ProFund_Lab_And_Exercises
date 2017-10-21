namespace P01.CountWorkingDays
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            string startData = Console.ReadLine();
            string endData = Console.ReadLine();

            DateTime startTime = DateTime.ParseExact(startData, "dd-MM-yyyy", CultureInfo.InvariantCulture);
            DateTime endTime = DateTime.ParseExact(endData, "dd-MM-yyyy", CultureInfo.InvariantCulture);
            int counter = 0;

            DateTime[] officialHolidays = new DateTime[]
            {
                 new DateTime(4, 01, 01),
                 new DateTime(4, 03, 03),
                 new DateTime(4, 05, 01),
                 new DateTime(4, 05, 06),
                 new DateTime(4, 05, 24),
                 new DateTime(4, 09, 06),
                 new DateTime(4, 09, 22),
                 new DateTime(4, 11, 01),
                 new DateTime(4, 12, 24),
                 new DateTime(4, 12, 25),
                 new DateTime(4, 12, 26),
            };

            for (DateTime date = startTime; date <= endTime; date = date.AddDays(1.0))
            {
                DateTime current = new DateTime(4, date.Month, date.Day);
                if ((date.DayOfWeek != DayOfWeek.Saturday) && (date.DayOfWeek != DayOfWeek.Sunday) && !(officialHolidays.Contains(current)))
                {
                    counter++;
                }

            }
            Console.WriteLine(counter);
        }
    }
}