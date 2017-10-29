namespace P01.MostFrequentNumber
{
    using System;
    using System.Linq;
    using System.IO;

    class StartUp
    {
        static void Main(string[] args)
        {
            string inputFilePath = "../../input.txt";
            string outputFilePath = "../../output.txt";

            string[] input = File.ReadAllLines(inputFilePath);

            File.WriteAllText(outputFilePath, string.Empty);

            for (int k = 0; k < input.Length; k++)
            {
                int[] numbers = input[k]
                    .Split(' ')
                    .Select(int.Parse)
                    .ToArray();
                int mostFrequentNumbr = 0;
                int repetitions = 0;

                for (int i = 0; i < numbers.Length; i++)
                {
                    int currentNumber = numbers[i];
                    int counter = 0;
                    for (int j = i; j < numbers.Length; j++)
                    {
                        if (currentNumber == numbers[j])
                        {
                            counter++;
                        }
                    }
                    if (counter > repetitions)
                    {
                        mostFrequentNumbr = currentNumber;
                        repetitions = counter;
                    }
                }
                File.AppendAllText(outputFilePath, mostFrequentNumbr.ToString());
                File.AppendAllText(outputFilePath, Environment.NewLine);
            }
        }
    }
}
