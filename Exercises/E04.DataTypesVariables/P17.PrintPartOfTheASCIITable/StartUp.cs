namespace P17.PrintPartOfTheASCIITable
{
    using System;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            int number01 = int.Parse(Console.ReadLine());
            int number02 = int.Parse(Console.ReadLine());

            for (int i = number01; i <= number02; i++)
            {
                char simbul = Convert.ToChar(i);

                String text = simbul + " ";

                Console.Write(text);
            }

            Console.WriteLine();
        }
    }
}
