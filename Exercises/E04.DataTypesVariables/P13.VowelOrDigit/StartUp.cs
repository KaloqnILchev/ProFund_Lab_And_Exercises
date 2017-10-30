namespace P13.VowelOrDigit
{
    using System;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            string text = Console.ReadLine();

            if (text == "a" || text == "e" || text == "i" || text == "o" || text == "u")
            {
                Console.WriteLine("vowel");
            }
            else if (text == "1" || text == "2" || text == "3" || text == "4" || text == "5" || text == "6" || text == "7" || text == "8" || text == "9" || text == "0")
            {
                Console.WriteLine("digit");
            }
            else
            {
                Console.WriteLine("other");
            }

        }
    }
}
