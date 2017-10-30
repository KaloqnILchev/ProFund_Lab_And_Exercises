namespace P02.ExtractSentencesByKeyword
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;
    using System.Threading.Tasks;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            string word = Console.ReadLine();
            string text = Console.ReadLine();

            string[] sentences = text.Split(new char[] { '?', '!', '.' }, StringSplitOptions.RemoveEmptyEntries);

            string pattern = "\\b" + word + "\\b";

            Regex regex = new Regex(pattern);

            foreach (var senterce in sentences)
            {
                if (regex.IsMatch(senterce))
                {
                    Console.WriteLine(senterce.Trim());
                }
            }
        }
    }
}
