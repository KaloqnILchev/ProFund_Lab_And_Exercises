namespace P05.HandsOfCards
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            string input;
            Dictionary<string, List<string>> players = new Dictionary<string, List<string>>();

            while ((input = Console.ReadLine()) != "Joker")
            {
                string[] playersEnters = input.Split(':').ToArray();
                string playerName = playersEnters[0];
                string playerHand = playersEnters[1];

                string[] playerCards = playerHand.Split(new char[] { ',', ' ' },
                    StringSplitOptions.RemoveEmptyEntries).ToArray();

                Console.WriteLine($"{playerName}");
                Console.WriteLine($"{playerHand}");
                foreach (var item in playerCards)
                {
                    Console.Write(item + " ");
                }
            }
        }
    }
}
