namespace P05.AMinerTask
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            string inputFilePath = "../../input.txt";
            string outputFilePath = "../../output.txt";

            string[] inputEnterce = File.ReadAllLines(inputFilePath);

            File.WriteAllText(outputFilePath, string.Empty);

            var mineralDic = new Dictionary<string, int>();

            for (int k = 0; k < inputEnterce.Length; k += 2)
            {
                string resource = inputEnterce[k];

                if (resource == "stop")
                {
                    break;
                }
                int quantity = int.Parse(inputEnterce[k + 1]);

                if (!mineralDic.ContainsKey(resource))
                {
                    mineralDic[resource] = quantity;
                }
                else
                {
                    mineralDic[resource] += quantity;
                }

            }
            foreach (var item in mineralDic)
            {
                File.AppendAllText(outputFilePath, $"{item.Key} -> {item.Value}");
                File.AppendAllText(outputFilePath, Environment.NewLine);
            }
        }
    }
}
