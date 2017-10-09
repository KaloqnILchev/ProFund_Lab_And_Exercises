namespace ConsoleApp1
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(' ').Select(ss => int.Parse(ss)).ToArray();
            int k = int.Parse(Console.ReadLine());

            int[] sumArr = new int[array.Length];

            for (int i = 0; i < k; i++)
            {
                RotateArray(array, sumArr);
            }
            Console.WriteLine(string.Join(" ", sumArr));
        }

        public static void RotateArray(int[] input, int[] sum)
        {
            var last = input.Length - 1;
            for (var i = 0; i < input.Length - 1; i += 1)
            {
                input[i] ^= input[last];
                input[last] ^= input[i];
                input[i] ^= input[last];
            }
            for (int i = 0; i < input.Length; i++)
            {
                sum[i] += input[i];
            }

        }
    }
}
