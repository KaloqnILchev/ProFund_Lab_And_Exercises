namespace P07.CakeIngredients
{
    using System;
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string ingredients = "";
            int count = 0;

            for (; ; )
            {
                ingredients = Console.ReadLine();

                if (ingredients != "Bake!")
                {
                    Console.WriteLine($"Adding ingredient {ingredients}.");
                    count++;
                }
                else
                {
                    Console.WriteLine($"Preparing cake with {count} ingredients.");
                    break;
                }

            }

        }
    }
}
