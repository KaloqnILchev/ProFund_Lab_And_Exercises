using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace P02.IndexOfLetters
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string[] alphabet = new string[]
                {
                "a","b","c","d","e","f","g","h","i","j","k","l","m","n","o","p","q","r","s","t","u","v","w","x","y","z"
                };
            string inputFilePath = "../../input.txt";
            string outputFilePath = "../../output.txt";

            File.WriteAllText(outputFilePath, string.Empty);

            var text = File.ReadAllText(inputFilePath);

            string input = text;

            for (int j = 0; j < input.Length; j++)
            {
                for (int i = 0; i < alphabet.Length; i++)
                {
                    if (input[j].ToString().Contains(alphabet[i]))
                    {
                        var number = i;
                        File.AppendAllText(outputFilePath, $"{input[j]} -> {number}");
                        File.AppendAllText(outputFilePath, Environment.NewLine);
                    }
                }
            }
        }
    }
}
