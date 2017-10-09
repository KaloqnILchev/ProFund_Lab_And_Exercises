using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P06.PrimeChecker
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            long number = long.Parse(Console.ReadLine());

            Console.WriteLine(IsPrime(number));

        }

        static bool IsPrime(long input)
        {
            double primeNumberChecker = Math.Sqrt(input);

            if (input == 0 || input == 1)
            {
                return false;
            }
            for (int i = 2; i <= primeNumberChecker; i++)
            {
                if (input % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
