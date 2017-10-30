namespace P09.ReverseCharacters
{
    using System;

    public class Program
    {
        public static void Main(string[] args)
        {
            char letter01 = char.Parse(Console.ReadLine());
            char letter02 = char.Parse(Console.ReadLine());
            char letter03 = char.Parse(Console.ReadLine());

            Console.WriteLine($"{letter03}{letter02}{letter01}");

        }
    }
}
