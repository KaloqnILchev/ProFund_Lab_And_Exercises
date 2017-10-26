namespace P02.AdvertisementMessage
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Startup
    {
        public static void Main(string[] args)
        {
            List<string> phrases = new List<string>
            {
                "Excellent product.",
                "Such a great product.",
                "I always use that product.",
                "Best product of its category.",
                "Exceptional product.",
                "I can’t live without this product.",
            };
            List<string> events = new List<string>
            {
                "Now I feel good.",
                "I have succeeded with this product.",
                "Makes miracles. I am happy of the results!",
                "I cannot believe but now I feel awesome.",
                "Try it yourself, I am very satisfied.",
                "I feel great!"
            };
            List<string> authors = new List<string>
                {
                "Diana",
                "Petya",
                "Stella",
                "Elena",
                "Katya",
                "Iva",
                "Annie",
                "Eva"
            };
            List<string> cities = new List<string>
                {
                "Burgas",
                "Sofia",
                "Plovdiv",
                "Varna",
                "Ruse"
            };
            int n = int.Parse(Console.ReadLine());

            Random nextMsg = new Random();

            for (int i = 0; i < n; i++)
            {
                var indexPhrase = nextMsg.Next(0, phrases.Count);
                var phrase = phrases[indexPhrase];
                var indexEven = nextMsg.Next(0, events.Count);
                var even = events[indexEven];
                var indexAuthor = nextMsg.Next(0, authors.Count);
                var author = authors[indexAuthor];
                var indexCity = nextMsg.Next(0, cities.Count);
                var city = cities[indexCity];
                Console.WriteLine($"{phrase} {even} {author} – {city}");
            }

        }
    }
}
