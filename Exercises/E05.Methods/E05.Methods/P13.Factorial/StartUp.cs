

namespace P13.Factorial
{
    using System;
    using System.Numerics;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            CalculatesAndPrintTheNFacturial(n);
        }

        private static void CalculatesAndPrintTheNFacturial(int n)
        {
            BigInteger factorial = 1;

            for (int i = 1; i <= n; i++)
            {
                factorial = factorial * i;
            }

            Console.WriteLine(factorial);
        }
    }
}
