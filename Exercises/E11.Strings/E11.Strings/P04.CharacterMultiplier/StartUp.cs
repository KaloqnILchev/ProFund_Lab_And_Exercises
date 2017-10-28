namespace P04.CharacterMultiplier
{
    using System;
    using System.Linq;
    
    class StartUp
    {
        static void Main(string[] args)
        {

            string[] input = Console.ReadLine().Split(' ').ToArray();
            char[] firstWord = input[0].ToCharArray();
            char[] secondWord = input[1].ToCharArray();
            
            int Sum = 0;

            if (firstWord.Length == secondWord.Length)
            {

                for (int i = 0; i < firstWord.Length; i++)
                {
                    
                    Sum += firstWord[i] * secondWord[i];
                }
                Console.WriteLine(Sum);
            }
            else if (firstWord.Length > secondWord.Length)
            {
                for (int i = 0; i < secondWord.Length; i++)
                {
                    Sum += firstWord[i] * secondWord[i];
                }
                for (int i = secondWord.Length; i < firstWord.Length; i++)
                {
                    Sum += firstWord[i];
                }
                Console.WriteLine(Sum);
            }
            else
            {
                for (int i = 0; i < firstWord.Length; i++)
                {
                    Sum += firstWord[i] * secondWord[i];
                }
                for (int i = firstWord.Length; i < secondWord.Length; i++)
                {
                    Sum += secondWord[i];
                }
                Console.WriteLine(Sum);
            }
        }
    }
}
