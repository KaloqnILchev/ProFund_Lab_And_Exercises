﻿namespace P04.Files
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;
    using System.Threading.Tasks;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            List<string> allFiles = new List<string>();

            for (int i = 0; i < n; i++)
            {
                allFiles.Add(Console.ReadLine());
            }

            string filter = Console.ReadLine();
            var filterTokens = Regex.Split(filter, " in ");
            var filterExt = "." + filterTokens[0];
            var filterRoot = filterTokens[1] + @"\";

            Dictionary<string, int> fileSize = new Dictionary<string, int>();

            foreach (var f in allFiles)
            {
                var filePluseSize = f.Split(';');
                var size = int.Parse(filePluseSize[1]);
                var path = filePluseSize[0];

                if (path.StartsWith(filterRoot) && path.EndsWith(filterExt))
                {
                    var tokens = path.Split('\\');
                    var fileName = tokens[tokens.Length - 1];
                    fileSize[fileName] = size;
                }
            }

            var sortedOutputFiles =
                fileSize.OrderByDescending(fs => fs.Value)
                .ThenBy(fs => fs.Key);

            foreach (var file in sortedOutputFiles)
            {
                Console.WriteLine(file.Key + " - " + file.Value + " KB");
            }
            if (sortedOutputFiles.Count() == 0)
            {
                Console.WriteLine("No");
            }
        }
    }
}
