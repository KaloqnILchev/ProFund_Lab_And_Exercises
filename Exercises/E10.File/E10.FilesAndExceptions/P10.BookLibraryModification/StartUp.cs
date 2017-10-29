namespace P10.BookLibraryModification
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    using System.IO;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            string inputFilePath = "../../input.txt";
            string outputFilePath = "../../output.txt";

            string[] entrence = File.ReadAllLines(inputFilePath);

            File.WriteAllText(outputFilePath, string.Empty);

            List<Book> bookList = new List<Book>();

            for (int k = 0; k < entrence.Length - 1; k++)
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
            DateTime date = DateTime.ParseExact(entrence[5], "dd.MM.yyyy", CultureInfo.InvariantCulture);

            List<Book> booksReleasedAfterDate = new List<Book>();
            foreach (var book in bookList)
            {
                if (book.ReleaseDate > date)
                {
                    booksReleasedAfterDate.Add(book);
                }
            }
            foreach (var book in booksReleasedAfterDate
                                    .OrderBy(x => x.ReleaseDate)
                                    .ThenBy(x => x.Title))
            {
                var outputInfo = ($"{book.Title} -> {book.ReleaseDate.ToString("dd.MM.yyyy", CultureInfo.InvariantCulture)}");
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