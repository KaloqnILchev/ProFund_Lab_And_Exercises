namespace P06.SumReversedNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            List<string> inputNumbers = Console.ReadLine().Split(' ').ToList();
            List<string> reverseInput = new List<string>();
            string reverse = "";

            foreach (var item in inputNumbers)
            {
                for (int i = item.Length - 1; i >= 0 ; i--)
                {
                    reverse += item[i];
                }

                reverseInput.AddRange();

            }
            foreach (var item in reverseInput)
            {
                Console.Write(item);
            }
            Console.WriteLine();
        
        }
    }
}
