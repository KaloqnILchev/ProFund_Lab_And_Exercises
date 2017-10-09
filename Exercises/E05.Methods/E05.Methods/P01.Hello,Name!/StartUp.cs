namespace P01.Hello_Name_
{
    using System;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            Greating();
        }
        static void Greating()
        {
            string name = Console.ReadLine();
            Console.WriteLine($"Hello, {name}!");
        }
    }
}
