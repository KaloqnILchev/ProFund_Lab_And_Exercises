namespace P03.SearchForANumber
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            List<int> inputNumbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int[] elements = new int[3];
            elements = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            bool isThere = false;

            inputNumbers.Take(elements[0]);

            for (int i = 0; i < elements[1]; i++)
            {
                inputNumbers.RemoveAt(0);
            }
            foreach (var item in inputNumbers)
            {
                if (item == elements[2])
                {
                    isThere = true;
                }

            }
            if (isThere)
            {
                Console.WriteLine("YES!");
            }
            else
            {
                Console.WriteLine("NO!");
            }
        }
    }
}
