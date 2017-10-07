namespace P06.TheatrePromotion
{
    using System;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            string typeOfDay = Console.ReadLine().ToLower();
            int age = int.Parse(Console.ReadLine());

            if (age >= 0 && age <= 18)
            {
                switch (typeOfDay)
                {
                    case "weekday":
                        Console.WriteLine("12$");
                        break;
                    case "weekend":
                        Console.WriteLine("15$");
                        break;
                    case "holiday":
                        Console.WriteLine("5$");
                        break;
                    default:
                        Console.WriteLine("Error!");
                        break;
                }
            }
            else if (age > 18 && age <= 64)
            {
                switch (typeOfDay)
                {
                    case "weekday":
                        Console.WriteLine("18$");
                        break;
                    case "weekend":
                        Console.WriteLine("20$");
                        break;
                    case "holiday":
                        Console.WriteLine("12$");
                        break;
                    default:
                        Console.WriteLine("Error!");
                        break;
                }
            }
            else if (age > 64 && age <= 122)
            {
                switch (typeOfDay)
                {
                    case "weekday":
                        Console.WriteLine("12$");
                        break;
                    case "weekend":
                        Console.WriteLine("15$");
                        break;
                    case "holiday":
                        Console.WriteLine("10$");
                        break;
                    default:
                        Console.WriteLine("Error!");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Error!");
            }
        }
    }
}
