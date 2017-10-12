namespace P10.PairsByDifference
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int difference = int.Parse(Console.ReadLine());

            int count = 0;

            for (int i = 0; i < input.Length; i++)
            {
                int currentNum = input[i];

                for (int j = i + 1; j < input.Length; j++)
                {
                    int secondNum = input[j];

                    if (currentNum - secondNum == difference || secondNum - currentNum == difference)
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine(count);
        }
    }
}
