namespace P07.ExchangeVariableValues
{
    using System;

    public class StartUp
    {
       public static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            int c = b;
            int d = a;

            Console.WriteLine($"Before:\r\na = {a}\r\nb = {b}\r\nAfter:\r\na = { c}\r\nb = { d}\r\n");

        }
    }
}
