namespace P10.MultiplicationTable2._0
{
    using System;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int multiplier = int.Parse(Console.ReadLine());

            int result;

            if (multiplier > 10)
            {
                result = number * multiplier;
                Console.WriteLine($"{number} X {multiplier} = {result}");
            }
            else
            {
                for (int i = multiplier; i <= 10; i++)
                {
                    result = number * i;
                    Console.WriteLine($"{number} X {i} = {result}");
                }
            }
        }
    }
}
