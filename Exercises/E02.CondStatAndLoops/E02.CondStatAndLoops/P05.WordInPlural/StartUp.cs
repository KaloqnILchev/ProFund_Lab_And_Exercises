namespace P05.WordInPlural
{
    using System;
    using System.Text;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string output = "";

            if (input.EndsWith("y") == true)
            {
                output = input.Remove(startIndex: input.Length - 1, count: 1);
                Console.WriteLine(output + "ies");
            }
            else if (input.EndsWith("o") || input.EndsWith("ch") || input.EndsWith("s") || input.EndsWith("sh")
                || input.EndsWith("x") || input.EndsWith("z") == true)
            {
                Console.WriteLine(input + "es");
            }
            else
            {
                Console.WriteLine(input + "s");
            }

        }
    }
}