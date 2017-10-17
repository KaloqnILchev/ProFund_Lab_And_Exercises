namespace P05.ArrayManipulator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main(string[] args)
        {

            List<long> numbers = Console.ReadLine().Split(' ').Select(long.Parse).ToList();

            string command = Console.ReadLine();

            while (command != "print")
            {
                string[] input = command.Split(' ');

                switch (input[0])
                {
                    case "add":
                        int index = int.Parse(input[1]);
                        long element = long.Parse(input[2]);
                        numbers.Insert(index, element);
                        break;
                    case "addMany":
                        index = int.Parse(input[1]);
                        List<long> manyElements = input.Skip(2).Select(long.Parse).ToList();
                        numbers.InsertRange(index, manyElements);
                        break;
                    case "contains":
                        element = long.Parse(input[1]);
                        Console.WriteLine(numbers.IndexOf(element));
                        break;
                    case "remove":
                        index = int.Parse(input[1]);
                        numbers.RemoveAt(index);
                        break;
                    case "shift":
                        int numberOfPositions = int.Parse(input[1]);
                        for (int i = 0; i < numberOfPositions; i++)
                        {
                            long first = numbers[0];
                            for (int j = 0; j < numbers.Count-1; j++)
                            {
                                numbers[j] = numbers[j + 1];
                            }
                            numbers[numbers.Count - 1] = first;
                        }                        
                        break;
                    case "sumPairs":
                        List<long> temp = new List<long>();

                        for (int i = 1; i < numbers.Count; i+= 2)
                        {
                            long firstNumber = numbers[i];
                            long secondNumber = numbers[i - 1];
                            temp.Add(firstNumber + secondNumber);
                        }
                        if (numbers.Count % 2 != 0 )
                        {
                            temp.Add(numbers[numbers.Count - 1]);
                        }
                        numbers.Clear();
                        numbers.AddRange(temp);
                        break;
                }
                command = Console.ReadLine();
            }
            Console.WriteLine("[" + string.Join(", ", numbers) + "]");
        }
    }
}
