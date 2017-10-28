namespace P03.UnicodeCharacters
{
    using System;
    using System.Text;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Console.WriteLine(GetUnicodeString(input));                     

        }
        static string GetUnicodeString(string str)
        {
            StringBuilder sb = new StringBuilder();
            foreach (char cha in str)
            {
                sb.Append("\\u");
                sb.Append(String.Format("{0:x4}", (int)cha));
            }
            return sb.ToString();
        }
    }
}
