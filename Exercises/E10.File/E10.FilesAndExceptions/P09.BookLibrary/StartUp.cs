﻿namespace P09.BookLibrary
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.IO;
    using System.Globalization;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            string inputFilePath = "../../input.txt";
            string outputFilePath = "../../output.txt";

            string[] entrence = File.ReadAllLines(inputFilePath);
            File.WriteAllText(outputFilePath, string.Empty);


            List<Book> bookList = new List<Book>();

            for (int k = 0; k < entrence.Length; k++)
            {
                string[] input = entrence[k].Split().ToArray();
                string title = input[0];
                string author = input[1];
                string publisher = input[2];
                DateTime releaseDate = DateTime.ParseExact(input[3], "dd.MM.yyyy", CultureInfo.InvariantCulture);
                int isbnNumber = int.Parse(input[4]);
                double price = double.Parse(input[5]);

                Book book = new Book
                {
                    Title = title,
                    Author = author,
                    Publiser = publisher,
                    ReleaseDate = releaseDate,
                    ISBNnumber = isbnNumber,
                    Price = price
                };
                bookList.Add(book);

            }
            Dictionary<string, double> authorsProfit = new Dictionary<string, double>();
            foreach (var book in bookList)
            {
                if (!authorsProfit.ContainsKey(book.Author))
                {
                    authorsProfit[book.Author] = book.Price;
                }
                else if (authorsProfit.ContainsKey(book.Author))
                {
                    authorsProfit[book.Author] += book.Price;
                }
            }
            foreach (var author in authorsProfit
                                        .OrderByDescending(x => x.Value)
                                        .ThenBy(x => x.Key))
            {
                var outputInfo = $"{author.Key} -> {author.Value:F2}";
                File.AppendAllText(outputFilePath, outputInfo);
                File.AppendAllText(outputFilePath, Environment.NewLine);
            }
        }
    }
    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Publiser { get; set; }
        public DateTime ReleaseDate { get; set; }
        public int ISBNnumber { get; set; }
        public double Price { get; set; }
    }
}