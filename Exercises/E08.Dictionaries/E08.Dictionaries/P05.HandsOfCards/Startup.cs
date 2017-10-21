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
            Dictionary<string, HashSet<int>> players = new Dictionary<string, HashSet<int>>();

            Dictionary<string, int> cardPowers = new Dictionary<string, int>()
                {
                    { "2", 2}, { "3", 3}, { "4", 4}, { "5", 5}, { "6", 6},
                    { "7", 7}, { "8", 8}, { "9", 9}, { "10", 10}, { "J", 11},
                    { "Q", 12}, { "K", 13}, { "A", 14}

                };
            Dictionary<string, int> cardTypes = new Dictionary<string, int>()
                {
                    { "S", 4}, { "H", 3}, { "D", 2}, { "C", 1}
                };

            while ((input = Console.ReadLine()) != "JOKER")
            {
                var playersEnters = input.Split(':');
                var playerName = playersEnters[0];
                var playerCards = playersEnters[1].Split(", ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

                foreach (var card in playerCards)
                {
                    var cardPower = card.Substring(0, card.Length - 1);
                    var cardType = card.Substring(card.Length - 1);

                    var sum = cardPowers[cardPower] * cardTypes[cardType];

                    if (!players.ContainsKey(playerName))
                    {
                        players[playerName] = new HashSet<int>();
                    }
                    players[playerName].Add(sum);
                }               
            }
            foreach (var person in players)
            {
                var name = person.Key;
                var cardsSum = person.Value.Sum();

                Console.WriteLine($"{name}: {cardsSum}");
            }
        }
    }
}
