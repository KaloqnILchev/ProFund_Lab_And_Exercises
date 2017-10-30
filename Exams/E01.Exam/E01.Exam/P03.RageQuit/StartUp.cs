namespace P03.RageQuitVar1
{
    using System;

    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;


    public class StartUp
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"([^0-9]+)(\d+)";

            StringBuilder result = new StringBuilder();
            
            foreach (Match m in Regex.Matches(input, pattern))
            {
                string word = m.Groups[1].Value.ToUpper();
                int count = int.Parse(m.Groups[2].Value);

                for (int i = 0; i < count; i++)
                {
                    result.Append(word);
                }
            }
            int uniqieChars = result.ToString().Distinct().Count();
            Console.WriteLine($"Unique symbols used: {uniqieChars}");
            Console.WriteLine(result.ToString());
        }
    }
}
