namespace P04.BeverageLabels
{
    using System;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            string nameOfBeverage = Console.ReadLine();
            double volume = double.Parse(Console.ReadLine());
            double energyContentPer100ml = double.Parse(Console.ReadLine());
            double sugarContentPer100ml = double.Parse(Console.ReadLine());

            double energyContent = volume * energyContentPer100ml / 100.0;
            double sugarContent = volume * sugarContentPer100ml / 100.0;

            Console.WriteLine($"{volume}ml {nameOfBeverage}:\r\n " +
                $"{energyContent}kcal, {sugarContent}g sugars");

        }
    }
}