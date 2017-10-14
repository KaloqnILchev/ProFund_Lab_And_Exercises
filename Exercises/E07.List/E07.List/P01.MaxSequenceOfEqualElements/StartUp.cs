namespace P01.MaxSequenceOfEqualElements
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    
    public class StartUp
    {
        public static void Main(string[] args)
        {
            List<int> inputNumbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            int count = 1;
            int bestStart = 0;
            int bestLength = 0;

            for (int i = 1; i < inputNumbers.Count; i++)
            {
                if (inputNumbers[i] == inputNumbers[i - 1])
                {
                    count++;
                }
                else
                {
                    count = 1;
                }
                if (count > bestStart)
                {
                    bestStart = count;
                    bestLength = i - count + 1;
                }
            }
            if (count == 1)
            {
                Console.WriteLine(inputNumbers[0]);
            }
            else
            {
                for (int i = bestLength; i < bestLength + bestStart; i++)
                {
                    Console.Write(inputNumbers[i] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
