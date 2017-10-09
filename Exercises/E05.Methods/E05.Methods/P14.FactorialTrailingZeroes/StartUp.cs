namespace P14.FactorialTrailingZeroes
{
    using System;
    using System.Numerics;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            CalculatesTheNFacturial(n);
        }

        private static void CalculatesTheNFacturial(int n)
        {
            BigInteger factorial = 1;

            for (int i = 1; i <= n; i++)
            {
                factorial = factorial * i;
            }

            CountZeroInFactorial(factorial);
        }

        private static void CountZeroInFactorial(BigInteger factorial)
        {
            string number = factorial.ToString();
            int counter = 0;

            for (int i = number.Length - 1; i >= 0; i--)
            {
                int zeroCheck = int.Parse(number[i].ToString());

                if(zeroCheck == 0)
                {
                    counter++;
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine(counter);
        }
    }
}
