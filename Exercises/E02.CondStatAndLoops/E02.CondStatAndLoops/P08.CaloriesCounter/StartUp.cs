namespace P08.CaloriesCounter
{
    using System;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string ingredients = "";
            int totalCalories = 0;
            int cheeseCalories = 500;
            int tomatoSauceCalories = 150;
            int salamiCalories = 600;
            int pepperCalories = 50;

            for (int i = 1; i <= n; i++)
            {
                ingredients = Console.ReadLine().ToLower();

                if (ingredients == "cheese")
                {
                    totalCalories += cheeseCalories;
                }
                else if (ingredients == "tomato sauce")
                {
                    totalCalories += tomatoSauceCalories;
                }
                else if (ingredients == "salami")
                {
                    totalCalories += salamiCalories;
                }
                else if (ingredients == "pepper")
                {
                    totalCalories += pepperCalories;
                }

            }
            Console.WriteLine($"Total calories: {totalCalories}");
        }
    }
}
