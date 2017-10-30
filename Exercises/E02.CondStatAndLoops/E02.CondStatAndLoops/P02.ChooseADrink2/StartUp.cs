namespace P02.ChooseADrink2
{
    using System;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            string profession = Console.ReadLine();
            int quantities = int.Parse(Console.ReadLine());
            double coffee = 1.00;
            double tea = 1.20;
            double beer = 1.70;
            double water = 0.70;
            double totalPrice;


            switch (profession)
            {
                case "Athlete":
                    totalPrice = quantities * water;
                    break;
                case "Businessman":
                case "Businesswoman":
                    totalPrice = quantities * coffee;
                    break;
                case "SoftUni Student":
                    totalPrice = quantities * beer;
                    break;
                default:
                    totalPrice = quantities * tea;
                    break;
            }
            Console.WriteLine($"The {profession} has to pay { totalPrice:F2}.");
        }
    }
}

