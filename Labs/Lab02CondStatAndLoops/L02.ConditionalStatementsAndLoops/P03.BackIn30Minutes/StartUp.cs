namespace P03.BackIn30Minutes
{
    using System;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            int newMinutes = minutes + 30;

            if (newMinutes >= 60)
            {
                newMinutes -= 60;
                hours += 1;

                if (hours >= 23)
                {
                    hours = 0;
                }
            }
            Console.WriteLine("{0}:{1:D2}",hours , newMinutes);
        }
    }
}
