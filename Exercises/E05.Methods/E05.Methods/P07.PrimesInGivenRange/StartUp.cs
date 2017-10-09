using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P07.PrimesInGivenRange
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());

            checkRangeForPrimes(firstNumber, secondNumber);
        }

        private static void checkRangeForPrimes(int firstNumber, int secondNumber)
        {
            List<int> numbers = new List<int>();

            if (firstNumber > secondNumber)
            {
                Console.WriteLine("(empty list)");
                return;
            }
            if (firstNumber <= 1 || secondNumber < 0)
            {
                firstNumber = 2;
            }
            for (int i = firstNumber; i <= secondNumber; i++)
            {
                bool isPrime = true;

                for (int j = 2; j <= Math.Sqrt(i); j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    numbers.Add(i);
                }
            }
            print(numbers);
        }
        public static void print(List<int> numbers)
        {
            Console.WriteLine(String.Join(", ", numbers));
        }
    }
}
