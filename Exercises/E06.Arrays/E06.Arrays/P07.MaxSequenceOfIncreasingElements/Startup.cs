namespace P07.MaxSequenceOfIncreasingElements
{
    using System;
    using System.Linq;

    public class Startup
    {
        public static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            var count = 1;
            var bestCount = 0;
            var bestIndex = 0;

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] > numbers[i - 1])
                {
                    count++;
                }
                else
                {
                    count = 1;
                }
                if (count > bestCount)
                {
                    bestCount = count;
                    bestIndex = i - count + 1;
                }
            }
            for (int i = bestIndex; i < bestIndex + bestCount; i++)
            {
                Console.Write(numbers[i] + " ");
            }
        }
    }
}
