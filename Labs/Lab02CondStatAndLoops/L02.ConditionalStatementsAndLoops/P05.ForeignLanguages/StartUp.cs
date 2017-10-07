namespace P05.ForeignLanguages
{
    using System;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            string countryName = Console.ReadLine().ToLower();

            switch (countryName)
            {
                case "usa":
                case "england":
                    Console.WriteLine("English");
                    break;
                case "spain":
                case "argentina":
                case "mexico":
                    Console.WriteLine("Spanish");
                    break;
                default:
                    Console.WriteLine("unknown");
                    break;
            }
        }
    }
}
