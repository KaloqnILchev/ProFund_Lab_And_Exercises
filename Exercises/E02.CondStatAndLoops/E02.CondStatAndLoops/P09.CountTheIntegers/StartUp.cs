namespace P09.CountTheIntegers
{
    using System;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            int number;
            int count = 0;
            bool isFalse = false;

            while (isFalse != true)
            {
                try
                {
                    number = int.Parse(Console.ReadLine());
                    count++;
                }
                catch (Exception)
                {
                    isFalse = true;
                    Console.WriteLine(count);
                    return;
                }
            }
        }
    }
}
