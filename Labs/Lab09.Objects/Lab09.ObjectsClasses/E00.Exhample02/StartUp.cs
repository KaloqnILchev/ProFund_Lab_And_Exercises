namespace E00.Exhample02
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split();

            var random = new Random();
            for (int i = 0; i < words.Length; i++)
            {
                int swapIndexFirst = random.Next(0, words.Length);
                int swapIndexSecond = random.Next(0, words.Length);

                string oldFirst = words[swapIndexFirst];
                words[swapIndexFirst] = words[swapIndexSecond]; 
                words[swapIndexSecond] = oldFirst;

            }

            Console.WriteLine( string.Join(Environment.NewLine, words));
        }
    }
}
