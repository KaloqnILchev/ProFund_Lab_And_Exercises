namespace P01.ExtractEmails
{
    using System;
    using System.Text.RegularExpressions;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string pattern = @"([\w.-]+\@[a-zA-Z-]+)(\.[a-zA-Z-]+)+";

            Regex regex = new Regex(pattern);
            MatchCollection matches = regex.Matches(text);

            foreach (Match emailMatch in matches)
            {
                string email = emailMatch.ToString();
                if (!(email.StartsWith(".") || email.StartsWith("-") || email.StartsWith("_")
                    || email.EndsWith(".")|| email.EndsWith("-")|| email.EndsWith("_")))
                { 
                    Console.WriteLine(emailMatch);
                }
            }
        }
    }
}
