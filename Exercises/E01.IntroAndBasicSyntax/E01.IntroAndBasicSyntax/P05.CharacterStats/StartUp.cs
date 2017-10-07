namespace P05.CharacterStats
{
    using System;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            string characterName = Console.ReadLine();
            int currentHealth = int.Parse(Console.ReadLine());
            int maximumHealth = int.Parse(Console.ReadLine());
            int currentEnergy = int.Parse(Console.ReadLine());
            int maximumEnergy = int.Parse(Console.ReadLine());

            int differenceInHealth = maximumHealth - currentHealth;
            int differenceInEnergy = maximumEnergy - currentEnergy;

            Console.WriteLine($"Name: {characterName}");
            Console.WriteLine($"Health: |{new string ('|', currentHealth)}" +
                              $"{new string('.', differenceInHealth)}|");
            Console.WriteLine($"Energy: |{new string('|', currentEnergy)}" +
                              $"{new string('.', differenceInEnergy)}|");


        }
    }
}
