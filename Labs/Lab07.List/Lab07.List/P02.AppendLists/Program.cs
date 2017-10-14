using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02.AppendLists
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string inPutLine = Console.ReadLine();

            List<int> numbers = new List<int>();

            string[] tokens = inPutLine.Split('|').ToArray();

            for (int i = tokens.Length - 1; i >= 0; i--)
            {
                string[] smallerString = tokens[i].Split(' ').ToArray();

                for (int j = 0; j < smallerString.Length; j++)
                {
                    if (true)
                    {

                    }
                }
                Console.WriteLine(string.Join(" ", numbers));
            }
            
        }
    }
}
