namespace P04.MaxSequenceOfEqualElements
{
    using System;
    using System.Linq;
    using System.IO;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            string inputFilePath = "../../input.txt";
            string outputFilePath = "../../output.txt";

            File.WriteAllText(outputFilePath, string.Empty);

            string[] text = File.ReadAllLines(inputFilePath);

            for (int k = 0; k < text.Length; k++)
            {
                var numbers = text[k].Split(' ').Select(int.Parse).ToArray();

                var count = 1;
                var bestCount = 0;
                var bestIndex = 0;
                string empty = " ";

                for (int i = 1; i < numbers.Length; i++)
                {
                    if (numbers[i] == numbers[i - 1])
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
                    File.AppendAllText(outputFilePath, $"{numbers[i]}{empty}");
                }
                File.AppendAllText(outputFilePath, Environment.NewLine);
            }
        }
    }
}
