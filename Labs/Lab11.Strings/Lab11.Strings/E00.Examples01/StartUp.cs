using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P00.Examples01
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string inputText = Console.ReadLine().ToLower();
            string pattern = Console.ReadLine().ToLower();

            int counter = 0;

            int index = inputText.IndexOf(pattern);

            while (index != -1)
            {
                counter++;
                index = inputText.IndexOf(pattern, index + 1);
            }

            Console.WriteLine(counter);

        }
    }
}
