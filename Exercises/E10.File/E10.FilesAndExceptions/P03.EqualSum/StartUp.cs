namespace P03.EqualSum
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
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse).ToArray();

                bool isFindEqualsSums = false;

                for (int i = 0; i < numbers.Length; i++)
                {
                    int[] leftSide = numbers.Take(i).ToArray();
                    int[] rightSide = numbers.Skip(i + 1).ToArray();

                    if (leftSide.Sum() == rightSide.Sum())
                    {
                        File.AppendAllText(outputFilePath, i.ToString());
                        File.AppendAllText(outputFilePath, Environment.NewLine);
                        isFindEqualsSums = true;
                        break;
                    }
                }
                if (!isFindEqualsSums)
                {
                    File.AppendAllText(outputFilePath,"no");
                    File.AppendAllText(outputFilePath, Environment.NewLine);
                }
            }
        }
    }
}
