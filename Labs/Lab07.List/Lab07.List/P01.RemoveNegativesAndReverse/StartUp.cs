namespace P01.RemoveNegativesAndReverse
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string inputLine = Console.ReadLine();
            List<int> listNumbers = inputLine.Split(' ').Select(int.Parse).ToList();

            for (int i = listNumbers.Count-1; i >= 0 ; i--)
            {

                if (listNumbers[i] < 0)
                {
                    listNumbers.RemoveAt(i);
                }
                
            }
            if (listNumbers.Count <= 0)
            {
                Console.WriteLine("empty");
            }
            else
            {
                listNumbers.Reverse();
                foreach (var number in listNumbers)
                {
                    Console.Write($"{number} ");
                }
                Console.WriteLine();
            }
            
        }
    }
}
