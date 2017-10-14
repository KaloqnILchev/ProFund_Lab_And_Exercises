namespace P02.ChangeList
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            List<int> inputNumbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            List<string> command = new List<string>();

            do
            {
                command = Console.ReadLine().Split(' ').ToList();

                switch (command[0])
                {
                    case "Delete":
                        while (inputNumbers.Remove((int.Parse)(command[1]))) { }
                        break;
                    case "Insert":
                        inputNumbers.Insert((int.Parse)(command[2]), (int.Parse)(command[1]));
                        break;
                }

            } while (command[0] != "Odd" && command[0] != "Even");

            if (command[0] == "Odd")
            {
                foreach (var element in inputNumbers)
                {
                    if (element % 2 != 0)
                    {
                        Console.Write(element + " ");
                    }
                }
                Console.WriteLine();
            }
            else if (command[0] == "Even")
            {
                foreach (var element in inputNumbers)
                {
                    if (element % 2 == 0)
                    {
                        Console.Write(element + " ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
