namespace P06.FixEmails
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.IO;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            Dictionary<string, string> mailContacts = new Dictionary<string, string>();

            string inputFilePath = "../../input.txt";
            string outputFilePath = "../../output.txt";

            File.WriteAllText(outputFilePath, string.Empty);

            string[] inputText = File.ReadAllLines(inputFilePath);

            for (int i = 0; i < inputText.Length; i += 2)
            {
                if (inputText[i] == "stop" || inputText[i + 1] == "stop")
                {
                    break;
                }
                var name = inputText[i];
                var email = inputText[i + 1];
                if (email.EndsWith(".uk") || email.EndsWith(".us"))
                {
                    continue;
                }

                var outputParameters = $"{name} -> {email}";

                File.AppendAllText(outputFilePath, outputParameters);
                File.AppendAllText(outputFilePath, Environment.NewLine);
            }
        }
    }
}
