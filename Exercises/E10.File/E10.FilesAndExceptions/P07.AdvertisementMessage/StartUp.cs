namespace P07.AdvertisementMessage
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    public  class StartUp
    {
        public  static void Main(string[] args)
        {
            string inputFilePhrases = "../../input01.txt";
            string inputFileEvents = "../../input02.txt";
            string inputFileAuthors = "../../input03.txt";
            string inputFileCities = "../../input04.txt";
            string outputFilePath = "../../output.txt";

            File.WriteAllText(outputFilePath, string.Empty);

            string[] inputPhrases = File.ReadAllLines(inputFilePhrases);
            string[] inputEvents = File.ReadAllLines(inputFileEvents);
            string[] inputAuthors = File.ReadAllLines(inputFileAuthors);
            string[] inputCities = File.ReadAllLines(inputFileCities);

            List<string> phrases = new List<string>();

            foreach (var item in inputPhrases)
            {
                phrases.Add(item);
            }
            List<string> events = new List<string>();
            foreach (var subitie in inputEvents)
            {
                events.Add(subitie);
            }
            List<string> authors = new List<string>();
            foreach (var person in inputAuthors)
            {
                authors.Add(person);
            }
            List<string> cities = new List<string>();
            foreach (var town in inputCities)
            {
                cities.Add(town);
            }

            Random nextMsg = new Random();
            Console.Write("Enter the Number of Advertisement: ");
            int n = int.Parse(Console.ReadLine());

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

                File.AppendAllText(outputFilePath, $"{phrase} {even} {author} – {city}");
                File.AppendAllText(outputFilePath, Environment.NewLine);

            }
        }
    }
}
