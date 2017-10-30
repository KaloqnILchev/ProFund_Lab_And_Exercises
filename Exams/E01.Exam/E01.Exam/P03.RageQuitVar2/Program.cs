namespace P03.RageQuitVar2
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;


    public class StartUp
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine();

            StringBuilder word = new StringBuilder();
            StringBuilder count = new StringBuilder();
            StringBuilder result = new StringBuilder();
            var inDigits = false;

            for (int i = 0; i < input.Length; i++)
            {
                char ch = Char.ToUpper(input[i]);
                if (inDigits)
                {
                    //Scan for digits
                    if (Char.IsDigit(ch))
                    {
                        count.Append(ch);
                    }
                    else
                    {
                        //word + count found;
                        for (int c = 0; c < int.Parse(count.ToString()); c++)
                            result.Append(word);
                        inDigits = false;
                        word.Clear();
                        word.Append(ch);
                    }
                }
                else
                {
                    //scan for letter
                    if (!Char.IsDigit(ch))
                    {
                        word.Append(ch);
                    }
                    else
                    {
                        //digit found;
                        inDigits = true;
                        count.Clear();
                        count.Append(ch);
                    }
                }
            }
            for (int c = 0; c < int.Parse(count.ToString()); c++)
                result.Append(word);

            Dictionary<char, bool> charOccurs = new Dictionary<char, bool>();
            foreach (var ch in result.ToString())
            {
                charOccurs[ch] = true;
            }
            var uniqieChars = charOccurs.Keys.Count;

            Console.WriteLine($"Unique symbols used: {uniqieChars}");
            Console.WriteLine(result.ToString());
        }
    }
}
